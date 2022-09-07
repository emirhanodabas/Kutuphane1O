﻿using KutuphaneYonetimi1OEntites.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneYonetimi1OEntites.Mapping
{
    public class PersonelMap: EntityTypeConfiguration<Personel>
    {
        public PersonelMap()
        {
            this.ToTable("tblPersonel");
            this.Property(p => p.PersonelId).HasColumnType("int");
            this.Property(p => p.PersonelId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.PersonelAdi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.PersonelEmail).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.PersonelKAdi).HasColumnType("varchar").HasMaxLength(30);
            this.Property(p => p.PersonelSoyadi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.PersonelParola).HasColumnType("varchar").HasMaxLength(30);
            this.Property(p => p.Fotograf).HasColumnType("varchar").HasMaxLength(200);
            this.Property(p => p.Telefon).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.DogumTarihi).HasColumnType("date");
        }
    }
}
