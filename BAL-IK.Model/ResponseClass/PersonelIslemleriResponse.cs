﻿using BAL_IK.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_IK.Model.ResponseClass
{
    public class PersonelIslemleriResponse
    {
        public class PersonelEkleResponse : BaseResponse
        {

        }
        public class PersonelGuncelleResponse : BaseResponse
        {

        }
        public class PersonelListelemeResponse : BaseResponse
        {
            public List<PersonelResp> PersonelListeleme { get; set; }

        }
        public class HarcamaListelemeResponse : BaseResponse
        {
            public List<HarcamaListeleResponse> HarcamaListele { get; set; }
        }
        public class PersonelResp : BaseResponse
        {

            public Guid Guid { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public DateTime DogumTarihi { get; set; }
            public string Eposta { get; set; }  //BENZERSİZ OLMALI!!!
            public string Sifre { get; set; }
            public string ResimUrl { get; set; }
            public bool AktifMi { get; set; }
            public int PersonelId { get; set; }
            public int YillikIzinHakki { get; set; } //WHAT CAN I DO SOMETİMES?LOOK AT THE TABELA!
            public DateTime IseBaslama { get; set; }
            public DateTime? IstenAyrilma { get; set; }
            public int SirketId { get; set; }
            public int? DepartmanId { get; set; }
            public int? VardiyaId { get; set; }
            public Cinsiyet Cinsiyet { get; set; }

        }
        public class PersonelHarcamaEkle : BaseResponse
        {
            public string DosyaYolu { get; set; }
            public int HarcamaId { get; set; }
            public int PersonelId { get; set; }
            public string HarcamaIsmi { get; set; }
            public decimal HarcamaTutari { get; set; }
        }
        public class HarcamaListeleResponse : BaseResponse
        {
            public string DosyaYolu { get; set; }
            public int HarcamaId { get; set; }
            public int PersonelId { get; set; }
            public string HarcamaIsmi { get; set; }
            public decimal HarcamaTutari { get; set; }
        }

        public class IzinResponse:BaseResponse
        {

        
            public int IzinId { get; set; }       
            public int IzinTurId { get; set; }
            public IzinTurler IzinTur { get; set; } = new IzinTurler();       
            public int IzinSuresi { get; set; }       
            public string ReddilmeNedeni { get; set; }            
            public DateTime IzinIstemeTarihi { get; set; }    
            public DateTime? OnaylanmaTarihi { get; set; }     
            public DateTime IzinBaslangicTarihi { get; set; }       
            public DateTime IzinBitisTarihi { get; set; }         
            public int PersonelId { get; set; }
           
            public int? SirketYoneticisiId { get; set; }
           
            public OnayDurumu OnayDurumu { get; set; }

        }
        public class IzinTurler:BaseResponse
        {
            public int IzinTurId { get; set; }            
            public string IzinTur { get; set; }          
        }
        public class IzinlerResponse:BaseResponse
        {
            public List<IzinResponse> Izinler { get; set; } = new List<IzinResponse>();
        }

        public class OzlukBelgesiEkleResponse : BaseResponse
        {
            public int OzlukBelgesiId { get; set; }
            public int PersonelId { get; set; }
            public string OzlukBelgesiAdi { get; set; }
            public string OzlukBelgesiYolu { get; set; }
            public DateTime OlusturulmaZamani { get; set; }
        }
        public class OzlukBelgesiGuncelleResponse : BaseResponse
        {

        }
        public class OzlukBelgesiSilResponse : BaseResponse
        {

        }
        public class EkleizinResponse : BaseResponse
        {
            public int IzinTurId { get; set; }
            public string IzinTur { get; set; }
            public int IzinSuresi { get; set; }
            public string ReddilmeNedeni { get; set; }
            public DateTime IzinIstemeTarihi { get; set; }
            public DateTime OnaylanmaTarihi { get; set; }
            public DateTime IzinBaslangicTarihi { get; set; }
            public DateTime IzinBitisTarihi { get; set; }
            public int PersonelId { get; set; }           
            public int SirketYoneticisiId { get; set; }
            public OnayDurumu OnayDurumu { get; set; }
        }
        
        public class ListelemeizinResponse : BaseResponse
        {
            public List<IzinListeleResponse> IzinListele { get; set; } = new List<IzinListeleResponse>();
        }
        public class IzinListeleResponse : BaseResponse
        {
            public int IzinTurId { get; set; }
            public string IzinTur { get; set; }
            public int IzinSuresi { get; set; }
            public string ReddilmeNedeni { get; set; }
            public DateTime IzinIstemeTarihi { get; set; }
            public DateTime OnaylanmaTarihi { get; set; }
            public DateTime IzinBaslangicTarihi { get; set; }
            public DateTime IzinBitisTarihi { get; set; }
            public int PersonelId { get; set; }
            //public Personeller Personel { get; set; }
            public int SirketYoneticisiId { get; set; }
            public OnayDurumu OnayDurumu { get; set; }
        }
        public class PersonelSilResponse:BaseResponse
        {
           

        }
    }
}
