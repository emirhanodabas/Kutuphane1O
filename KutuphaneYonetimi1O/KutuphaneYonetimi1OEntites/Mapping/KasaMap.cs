using KutuphaneYonetimi1OEntites.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimi1OEntites.Mapping
{
    public class KasaMap : EntityTypeConfiguration<Kasa>
    {
        public KasaMap()
        {
            this.ToTable("tblKasa");
            this.Property(p => p.KasaId).HasColumnType("int");
            this.Property(p => p.KasaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KasaAdi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.KasaMiktari).HasPrecision(15, 2);
        }
    }
}
