using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FarukEmlak.Models;

namespace FarukEmlak.Models
{
    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }
        public string AdSoyad { get; set; }
        public string TCno { get; set; }
        public string Yas { get; set; }
        public string Telno { get; set; }
        public string Parola { get; set; }

        public IList<Kiralik> Kiraliks { get; set; }
        public IList<Satilik> Satiliks { get; set; }
    }
}
