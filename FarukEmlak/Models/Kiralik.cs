using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FarukEmlak.Models;

namespace FarukEmlak.Models
{
    public class Kiralik
    {
        [Key]
        public int KiralikID { get; set; }
        public short Kira { get; set; }
        public string Odasay { get; set; }
        public byte MetreKare { get; set; }
        public byte Binayas { get; set; }
        public byte Binakat { get; set; }
        public byte Bulunkat { get; set; }
        public string Cephe { get; set; }
        public System.DateTime İlanTarih { get; set; }
        public bool Durum { get; set; }
        public string Sehir { get; set; }
        public string Semt { get; set; }
        public string Mahalle { get; set; }
        public string Adres { get; set; }
        public string Foto { get; set; }
        public string Aciklama { get; set; }
        public string Baslik { get; set; }

        public int MusteriID { get; set; }
        public Musteri Musteri { get; set; }
    }
}
