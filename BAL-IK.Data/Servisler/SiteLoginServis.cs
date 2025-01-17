﻿using BAL_IK.Data.Context;
using BAL_IK.Data.Interfaceler.Site;
using BAL_IK.Model.Entities;
using BAL_IK.Model.RequestClass;
using BAL_IK.Model.ResponseClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static BAL_IK.Model.ResponseClass.LogIslemleriResponse;
using static BAL_IK.Model.ResponseClass.SiteIslemleriResponse;

namespace BAL_IK.Data.Servisler
{
    public class SiteLoginServis : ISiteLoginServis
    {
        private readonly BAL_IKContext _db;

        public SiteLoginServis(BAL_IKContext db)
        {
            this._db = db;
        }

        public KayitKullaniciResp KayitIslemi(LogIslemleriRequest.KayitKullaniciReq req)
        {
            KayitKullaniciResp resp = new KayitKullaniciResp();
            if (string.IsNullOrEmpty(req.Email) || string.IsNullOrEmpty(req.Sifre) || string.IsNullOrEmpty(req.Ad) || string.IsNullOrEmpty(req.Soyad))
            {
                resp.Mesaj = "Tüm alanları eksiksiz doldurun.";
                resp.BasariliMi = false;
                return resp;
            }
            if (req.Sifre.Length < 6)
            {
                resp.Mesaj = "Şifre uzunluğu 6 karakterden az olamaz.";
                resp.BasariliMi = false;
                return resp;
            }
            try
            {
                SiteYoneticisi siteYoneticisi = _db.SiteYoneticileri.FirstOrDefault(x => x.Eposta == req.Email);
                Personeller personel = _db.Personeller.FirstOrDefault(x => x.Eposta == req.Email);
                SirketYoneticisi sirketYoneticisi = _db.SirketYoneticileri.FirstOrDefault(x => x.Eposta == req.Email);
                if (siteYoneticisi != null || personel != null || sirketYoneticisi != null)
                {
                    resp.Mesaj = "Bu mail adresi kullanılmaktadır.";
                    resp.BasariliMi = false;
                    return resp;
                }
                SirketYoneticisi yeniSirketYoneticisi = new SirketYoneticisi();
                yeniSirketYoneticisi.Eposta = req.Email;
                yeniSirketYoneticisi.Sifre = Tools.CreatePasswordHash(req.Sifre);
                yeniSirketYoneticisi.Ad = req.Ad;
                yeniSirketYoneticisi.Soyad = req.Soyad;
                _db.Add(yeniSirketYoneticisi);
                _db.SaveChanges();
                resp.Mesaj = Tools.MailGonder(yeniSirketYoneticisi.Eposta, "BAL-IK Kayıt", $"<h1><a href='http://localhost:47578/Login/Aktivasyon?guid={yeniSirketYoneticisi.Guid}'>Hesabınızı Aktif Etmek İçin Lütfen Tıklayın<a></h1>");
                resp.BasariliMi = true;
                return resp;

            }
            catch (Exception ex)
            {

                resp.Mesaj = ex.Message;
                resp.BasariliMi = false;
                return resp;
            }
        }



        public LogIslemleriResponse.LoginKullanici LoginIslemi(LogIslemleriRequest.LogKullanici log)
        {
            LoginKullanici resp = new LoginKullanici();
            if (string.IsNullOrEmpty(log.Email) || string.IsNullOrEmpty(log.Sifre))
            {
                resp.Mesaj = "Kullanıcı adı veya şifresi girilmedi.";
                resp.BasariliMi = false;
                return resp;
            }
            string hashSifre = Tools.CreatePasswordHash(log.Sifre);
            //string hashSifre=log.Sifre;
            try
            {
                SiteYoneticisi siteYoneticisi = _db.SiteYoneticileri.FirstOrDefault(x => x.Eposta == log.Email && x.Sifre == hashSifre);
                Personeller personel = _db.Personeller.Include(x => x.Sirket).FirstOrDefault(x => x.Eposta == log.Email && x.Sifre == hashSifre);
                SirketYoneticisi sirketYoneticisi = _db.SirketYoneticileri.Include(x => x.Sirket).FirstOrDefault(x => x.Eposta == log.Email && x.Sifre == hashSifre);

                if (siteYoneticisi != null)
                {
                    return response("siteYoneticisi", siteYoneticisi.Guid.ToString());
                }
                else if (personel != null)
                {
                    if (personel.AktifMi == false)
                    {
                        resp.BasariliMi = false;
                        resp.Mesaj = "Hesabınız aktif değildir lütfen yöneticinize danışın.";
                        return resp;
                    }
                    else if (personel.Sirket.Durum == Durum.Pasif)
                    {
                        resp.BasariliMi = false;
                        resp.Mesaj = "Şirketiniz Pasif Durumdadır.";
                        return resp;
                    }
                    return response("personel", personel.Guid.ToString());
                }
                else if (sirketYoneticisi != null)
                {

                    if (sirketYoneticisi.AktifMi == false)
                    {
                        resp.BasariliMi = false;
                        resp.Mesaj = "Hesabınız aktif değildir lütfen aktivasyonu sağlayın.";
                        return resp;
                    }
                    else if (sirketYoneticisi.SirketId != null && sirketYoneticisi.Sirket.Durum == Durum.Pasif)
                    {
                        resp.BasariliMi = false;
                        resp.Mesaj = "Şirketiniz henüz onaylanmamıştır.";
                        return resp;
                    }
                    return response("sirketYoneticisi", sirketYoneticisi.Guid.ToString());
                }
                else
                {
                    resp.BasariliMi = false;
                    resp.Mesaj = "Kullanıcı Adı veya Şifresi Yanlış";
                    return resp;
                }

            }
            catch (Exception ex)
            {
                resp.Mesaj = ex.Message;
                resp.BasariliMi = false;
                return resp;

            }
            LoginKullanici response(string kullaniciTuru, string Guid)
            {
                resp.KullaniciTuru = kullaniciTuru;
                resp.GirisGuid = Guid;
                resp.BasariliMi = true;
                resp.Mesaj = "Giriş Başarılı";
                return resp;
            }
        }

        public SiteIslemleriResponse.YorumlarResponse YorumlariGetir()
        {
            YorumlarResponse yorumlarResponse = new YorumlarResponse();
            try
            {
                yorumlarResponse.Yorumlar = new List<YorumResponse>();

                foreach (var yorum in _db.Yorumlar.Include(x => x.Sirket).ToList())
                {
                    YorumResponse eklenecekYorum = new YorumResponse()
                    {
                        SirketId = yorum.SirketId,
                        OlusturulmaTarihi = yorum.OlusturulmaTarihi,
                        YorumBaslik = yorum.YorumBaslik,
                        YorumIcerik = yorum.YorumIcerik,
                        YorumId = yorum.YorumId,
                        SirketAdi=yorum.Sirket.SirketAdi,
                        SirketLogoYolu=yorum.Sirket.SirketLogoURL
                    };
                    eklenecekYorum.BasariliMi = true;
                    
                    yorumlarResponse.Yorumlar.Add(eklenecekYorum);
                }
                yorumlarResponse.Mesaj = "Başarılı";
                yorumlarResponse.BasariliMi = true;

                return yorumlarResponse;
            }
            catch (Exception)
            {
                yorumlarResponse.Mesaj = "Yorumları getirirken bir hata oluştu";
                yorumlarResponse.BasariliMi = false;
                return yorumlarResponse;               
            }
         
        }
    }
}
