﻿using KutuphaneYonetimi1OEntites.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneYonetimi1OEntites.Mapping
{
    public class KitapHareketMap : EntityTypeConfiguration<KitapHareket>
    {
        public KitapHareketMap()
        {
            this.ToTable("tblKitapHareket");
            this.Property(p => p.KitapHareketId).HasColumnType("int");
            this.Property(p => p.KitapHareketId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.AlmaTarihi).HasColumnType("date");
            this.Property(p => p.IadeTarihi).HasColumnType("date");
            this.Property(p => p.KullaniciIadeTarihi).HasColumnType("date");
            this.Property(p => p.CezaUcreti).HasPrecision(11, 2);

            this.HasRequired(p => p.Personel).WithMany(p => p.KitapHarekets).HasForeignKey(p => p.PersonelId);
            this.HasRequired(p => p.Uye).WithMany(p => p.KitapHarekets).HasForeignKey(p => p.UyeId);
            this.HasRequired(p => p.Kitap).WithMany(p => p.KitapHarekets).HasForeignKey(p => p.KitapId);
        }
    }
}
