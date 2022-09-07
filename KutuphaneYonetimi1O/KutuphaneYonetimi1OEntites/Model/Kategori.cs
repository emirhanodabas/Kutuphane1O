using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimi1OEntites.Model
{
    public class Kategori
    {
        /// <summary>
        /// kategori bilgilerinin tutulduğu tablo yapısı
        /// </summary>
        /*
         prop 2 kere tap oto properties oluşturur
         */
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public bool KategoriDurumu { get; set; }
        public string KategoriAciklama { get; set; }

        public virtual ICollection<Kitap> Kitaps { get; set; }
    }
}
