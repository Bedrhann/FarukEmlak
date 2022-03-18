using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FarukEmlak.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string AdSoyad { get; set; }
        public string TCno { get; set; }       
        public string Parola { get; set; }
    }
}
