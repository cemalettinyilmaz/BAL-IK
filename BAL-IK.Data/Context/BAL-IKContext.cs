﻿using BAL_IK.Model;
using BAL_IK.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_IK.Data.Context
{
    public class BAL_IKContext : DbContext
    {
        public BAL_IKContext(DbContextOptions<BAL_IKContext> options):base(options)
        {

        }

        public DbSet<Departmanlar> Departmanlar { get; set; }
        public DbSet<Harcamalar> Harcamalar { get; set; }
        public DbSet<Izinler> Izinler { get; set; }
        public DbSet<IzinTuru> IzinTurleri { get; set; }
        public DbSet<MaasBilgisi> MaasBilgileri { get; set; }
        public DbSet<Mola> Molalar { get; set; }
        public DbSet<MolaTur> MolaTur { get; set; }
        public DbSet<OzlukBelgesi> OzlukBelgeleri { get; set; }
        public DbSet<Personeller> Personeller { get; set; }
        public DbSet<Prim> Primler { get; set; }
        public DbSet<PrimTuru> PrimTurleri { get; set; }
        public DbSet<Sirket> Sirketler { get; set; }
        public DbSet<SirketYoneticisi> SirketYoneticileri { get; set; }
        public DbSet<SiteYoneticisi> SiteYoneticileri { get; set; }
        public DbSet<Vardiyalar> Vardiyalar { get; set; }
        public DbSet<VardiyaTur> VardiyaTur { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
        public DbSet<Zimmetler> Zimmetler { get; set; }
        public DbSet<ZimmetTuru> ZimmetTurleri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //bire-bir sirket/yorum ilişkisi
            modelBuilder.Entity<Sirket>()
                .HasOne<Yorum>(x => x.Yorumu)
                .WithOne(s => s.Sirket)
                .HasForeignKey<Yorum>(x => x.SirketId);

            modelBuilder.Entity<SiteYoneticisi>().HasData(new SiteYoneticisi()
            {
                SiteYoneticisiId = 1,
                Ad = "BALIK",
                Soyad = "Admin",
                Cinsiyet = 0,
                AktifMi = true,
                DogumTarihi = DateTime.Now,
                Eposta = "admin@bal-ik.com",
                Guid = new Guid("c96ce224-3473-4d45-93fd-56b5f1d594ac"),
                ResimUrl = null,
                Sifre = "123456"
        });
        }
    }
}
