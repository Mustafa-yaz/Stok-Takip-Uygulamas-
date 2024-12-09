using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amp12A_603_StokTakipProgramı.Model
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        [ForeignKey("Yetki")]
        public int YetkiId { get; set; }

        public virtual Yetki Yetki { get; set; }
        public virtual ICollection<Satis> Satislar { get; set; } = new HashSet<Satis>();
    }
}
