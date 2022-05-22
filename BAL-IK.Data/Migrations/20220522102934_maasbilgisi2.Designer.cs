﻿// <auto-generated />
using System;
using BAL_IK.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BAL_IK.Data.Migrations
{
    [DbContext(typeof(BAL_IKContext))]
    [Migration("20220522102934_maasbilgisi2")]
    partial class maasbilgisi2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BAL_IK.Model.Entities.Departmanlar", b =>
                {
                    b.Property<int>("DepartmanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmanAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DepartmanAdresi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SirketId")
                        .HasColumnType("int");

                    b.HasKey("DepartmanId");

                    b.HasIndex("SirketId");

                    b.ToTable("Departmanlar");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.IzinTuru", b =>
                {
                    b.Property<int>("IzinTurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IzinTur")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IzinTurId");

                    b.ToTable("IzinTurleri");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.Izinler", b =>
                {
                    b.Property<int>("IzinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("IzinBaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IzinBitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IzinIstemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("IzinSuresi")
                        .HasColumnType("int");

                    b.Property<int>("IzinTurId")
                        .HasColumnType("int");

                    b.Property<int>("OnayDurumu")
                        .HasColumnType("int");

                    b.Property<DateTime>("OnaylanmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<string>("ReddilmeNedeni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SirketYoneticisiId")
                        .HasColumnType("int");

                    b.HasKey("IzinId");

                    b.HasIndex("IzinTurId");

                    b.HasIndex("PersonelId");

                    b.HasIndex("SirketYoneticisiId");

                    b.ToTable("Izinler");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.MaasBilgisi", b =>
                {
                    b.Property<int>("MaasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("MaasTutari")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VerilisTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("MaasId");

                    b.HasIndex("PersonelId");

                    b.ToTable("MaasBilgileri");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.OzlukBelgesi", b =>
                {
                    b.Property<int>("OzlukBelgesiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OlusturulmaZamani")
                        .HasColumnType("datetime2");

                    b.Property<string>("OzlukBelgesiAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OzlukBelgesiYolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<int>("SirketYoneticisiId")
                        .HasColumnType("int");

                    b.HasKey("OzlukBelgesiId");

                    b.HasIndex("PersonelId");

                    b.HasIndex("SirketYoneticisiId");

                    b.ToTable("OzlukBelgeleri");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.Personeller", b =>
                {
                    b.Property<int>("PersonelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<int>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmanId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("IseBaslama")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("IstenAyrilma")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResimUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("SirketId")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("TemelMaasBilgisi")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("VardiyaId")
                        .HasColumnType("int");

                    b.Property<int>("YillikIzinHakki")
                        .HasColumnType("int");

                    b.HasKey("PersonelId");

                    b.HasIndex("DepartmanId");

                    b.HasIndex("SirketId");

                    b.HasIndex("VardiyaId");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.PrimTuru", b =>
                {
                    b.Property<int>("PrimTuruId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PrimTur")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PrimTuruId");

                    b.ToTable("PrimTurleri");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.Sirket", b =>
                {
                    b.Property<int>("SirketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Durum")
                        .HasColumnType("int");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("OdemePlani")
                        .HasColumnType("int");

                    b.Property<string>("SirketAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SirketAdresi")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("SirketEmail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SirketLogoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SirketTelefonu")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<DateTime>("UyelikBitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("YorumId")
                        .HasColumnType("int");

                    b.HasKey("SirketId");

                    b.ToTable("Sirketler");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.SirketYoneticisi", b =>
                {
                    b.Property<int>("SirketYoneticisiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<int>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ResimUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("SirketId")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SirketYoneticisiId");

                    b.HasIndex("SirketId");

                    b.ToTable("SirketYoneticileri");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.SiteYoneticisi", b =>
                {
                    b.Property<int>("SiteYoneticisiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<int>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ResimUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SiteYoneticisiId");

                    b.ToTable("SiteYoneticileri");

                    b.HasData(
                        new
                        {
                            SiteYoneticisiId = 1,
                            Ad = "BALIK",
                            AktifMi = true,
                            Cinsiyet = 0,
                            DogumTarihi = new DateTime(2022, 5, 22, 13, 29, 33, 552, DateTimeKind.Local).AddTicks(9050),
                            Eposta = "admin@bal-ik.com",
                            Guid = new Guid("c96ce224-3473-4d45-93fd-56b5f1d594ac"),
                            Sifre = "123456",
                            Soyad = "Admin"
                        });
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.VardiyaTur", b =>
                {
                    b.Property<int>("VardiyaTurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VardiyaTuru")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("VardiyaTurId");

                    b.ToTable("VardiyaTur");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.Yorum", b =>
                {
                    b.Property<int>("YorumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OlusturulmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("SirketId")
                        .HasColumnType("int");

                    b.Property<string>("YorumBaslik")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("YorumIcerik")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.HasKey("YorumId");

                    b.HasIndex("SirketId")
                        .IsUnique();

                    b.ToTable("Yorumlar");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.ZimmetTuru", b =>
                {
                    b.Property<int>("ZimmetTuruId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ZimmetTur")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ZimmetTuruId");

                    b.ToTable("ZimmetTurleri");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.Zimmetler", b =>
                {
                    b.Property<int>("ZimmetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Durumu")
                        .HasColumnType("int");

                    b.Property<string>("NotIcerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<bool>("TeslimEdildiMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ZimmetTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ZimmetTeslimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("ZimmetTuruId")
                        .HasColumnType("int");

                    b.HasKey("ZimmetId");

                    b.HasIndex("PersonelId");

                    b.HasIndex("ZimmetTuruId");

                    b.ToTable("Zimmetler");
                });

            modelBuilder.Entity("BAL_IK.Model.Harcamalar", b =>
                {
                    b.Property<int>("HarcamaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DosyaYolu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HarcamaIsmi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("HarcamaTutari")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OlusturulmaZamani")
                        .HasColumnType("datetime2");

                    b.Property<bool>("OnayDurumu")
                        .HasColumnType("bit");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.HasKey("HarcamaId");

                    b.HasIndex("PersonelId");

                    b.ToTable("Harcamalar");
                });

            modelBuilder.Entity("BAL_IK.Model.Mola", b =>
                {
                    b.Property<int>("MolaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("MolaSuresi")
                        .HasColumnType("float");

                    b.Property<int>("MolaTurId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturulduguTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("MolaId");

                    b.HasIndex("MolaTurId");

                    b.ToTable("Molalar");
                });

            modelBuilder.Entity("BAL_IK.Model.MolaTur", b =>
                {
                    b.Property<int>("MolaTurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MolaTuru")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("MolaTurId");

                    b.ToTable("MolaTur");
                });

            modelBuilder.Entity("BAL_IK.Model.Prim", b =>
                {
                    b.Property<int>("PrimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrimMiktari")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PrimTuruId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PrimVerilisTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("PrimId");

                    b.HasIndex("PersonelId");

                    b.HasIndex("PrimTuruId");

                    b.ToTable("Primler");
                });

            modelBuilder.Entity("BAL_IK.Model.Vardiyalar", b =>
                {
                    b.Property<int>("VardiyaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("VardiyaBaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VardiyaBitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("VardiyaTurId")
                        .HasColumnType("int");

                    b.HasKey("VardiyaId");

                    b.HasIndex("VardiyaTurId");

                    b.ToTable("Vardiyalar");
                });

            modelBuilder.Entity("MolaPersoneller", b =>
                {
                    b.Property<int>("MolalarMolaId")
                        .HasColumnType("int");

                    b.Property<int>("PersonellerPersonelId")
                        .HasColumnType("int");

                    b.HasKey("MolalarMolaId", "PersonellerPersonelId");

                    b.HasIndex("PersonellerPersonelId");

                    b.ToTable("MolaPersoneller");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.Departmanlar", b =>
                {
                    b.HasOne("BAL_IK.Model.Entities.Sirket", "Sirketi")
                        .WithMany("Departmanlar")
                        .HasForeignKey("SirketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sirketi");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.Izinler", b =>
                {
                    b.HasOne("BAL_IK.Model.Entities.IzinTuru", "IzinTur")
                        .WithMany("Izinler")
                        .HasForeignKey("IzinTurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BAL_IK.Model.Entities.Personeller", "Personel")
                        .WithMany("Izinler")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BAL_IK.Model.Entities.SirketYoneticisi", "SirketYoneticisi")
                        .WithMany()
                        .HasForeignKey("SirketYoneticisiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IzinTur");

                    b.Navigation("Personel");

                    b.Navigation("SirketYoneticisi");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.MaasBilgisi", b =>
                {
                    b.HasOne("BAL_IK.Model.Entities.Personeller", "Personel")
                        .WithMany("MaasBilgileri")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.OzlukBelgesi", b =>
                {
                    b.HasOne("BAL_IK.Model.Entities.Personeller", "Personel")
                        .WithMany("OzlukBelgeleri")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BAL_IK.Model.Entities.SirketYoneticisi", "SirketYoneticisi")
                        .WithMany()
                        .HasForeignKey("SirketYoneticisiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");

                    b.Navigation("SirketYoneticisi");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.Personeller", b =>
                {
                    b.HasOne("BAL_IK.Model.Entities.Departmanlar", "Departman")
                        .WithMany("Personelleri")
                        .HasForeignKey("DepartmanId");

                    b.HasOne("BAL_IK.Model.Entities.Sirket", "Sirket")
                        .WithMany("Personeller")
                        .HasForeignKey("SirketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BAL_IK.Model.Vardiyalar", "Vardiya")
                        .WithMany("Personeller")
                        .HasForeignKey("VardiyaId");

                    b.Navigation("Departman");

                    b.Navigation("Sirket");

                    b.Navigation("Vardiya");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.SirketYoneticisi", b =>
                {
                    b.HasOne("BAL_IK.Model.Entities.Sirket", "Sirket")
                        .WithMany("SirketYoneticileri")
                        .HasForeignKey("SirketId");

                    b.Navigation("Sirket");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.Yorum", b =>
                {
                    b.HasOne("BAL_IK.Model.Entities.Sirket", "Sirket")
                        .WithOne("Yorumu")
                        .HasForeignKey("BAL_IK.Model.Entities.Yorum", "SirketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sirket");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.Zimmetler", b =>
                {
                    b.HasOne("BAL_IK.Model.Entities.Personeller", "Personel")
                        .WithMany("Zimmetler")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BAL_IK.Model.Entities.ZimmetTuru", "ZimmetTuru")
                        .WithMany("Zimmetler")
                        .HasForeignKey("ZimmetTuruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");

                    b.Navigation("ZimmetTuru");
                });

            modelBuilder.Entity("BAL_IK.Model.Harcamalar", b =>
                {
                    b.HasOne("BAL_IK.Model.Entities.Personeller", "Personel")
                        .WithMany("Harcamalar")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("BAL_IK.Model.Mola", b =>
                {
                    b.HasOne("BAL_IK.Model.MolaTur", "MolaTur")
                        .WithMany("Molalar")
                        .HasForeignKey("MolaTurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MolaTur");
                });

            modelBuilder.Entity("BAL_IK.Model.Prim", b =>
                {
                    b.HasOne("BAL_IK.Model.Entities.Personeller", "Personel")
                        .WithMany("Primler")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BAL_IK.Model.Entities.PrimTuru", "PrimTuru")
                        .WithMany("Primler")
                        .HasForeignKey("PrimTuruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");

                    b.Navigation("PrimTuru");
                });

            modelBuilder.Entity("BAL_IK.Model.Vardiyalar", b =>
                {
                    b.HasOne("BAL_IK.Model.Entities.VardiyaTur", "VardiyaTur")
                        .WithMany("Vardiyalar")
                        .HasForeignKey("VardiyaTurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VardiyaTur");
                });

            modelBuilder.Entity("MolaPersoneller", b =>
                {
                    b.HasOne("BAL_IK.Model.Mola", null)
                        .WithMany()
                        .HasForeignKey("MolalarMolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BAL_IK.Model.Entities.Personeller", null)
                        .WithMany()
                        .HasForeignKey("PersonellerPersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.Departmanlar", b =>
                {
                    b.Navigation("Personelleri");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.IzinTuru", b =>
                {
                    b.Navigation("Izinler");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.Personeller", b =>
                {
                    b.Navigation("Harcamalar");

                    b.Navigation("Izinler");

                    b.Navigation("MaasBilgileri");

                    b.Navigation("OzlukBelgeleri");

                    b.Navigation("Primler");

                    b.Navigation("Zimmetler");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.PrimTuru", b =>
                {
                    b.Navigation("Primler");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.Sirket", b =>
                {
                    b.Navigation("Departmanlar");

                    b.Navigation("Personeller");

                    b.Navigation("SirketYoneticileri");

                    b.Navigation("Yorumu");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.VardiyaTur", b =>
                {
                    b.Navigation("Vardiyalar");
                });

            modelBuilder.Entity("BAL_IK.Model.Entities.ZimmetTuru", b =>
                {
                    b.Navigation("Zimmetler");
                });

            modelBuilder.Entity("BAL_IK.Model.MolaTur", b =>
                {
                    b.Navigation("Molalar");
                });

            modelBuilder.Entity("BAL_IK.Model.Vardiyalar", b =>
                {
                    b.Navigation("Personeller");
                });
#pragma warning restore 612, 618
        }
    }
}
