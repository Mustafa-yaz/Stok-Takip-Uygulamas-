using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amp12A_603_StokTakipProgramı.Model
{
    public class Musteri
    {
        [Key]

        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string FirmaAdi { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }



        public virtual ICollection<Satis> Satıslar { get; set;}=new HashSet<Satis>();



    }
}
