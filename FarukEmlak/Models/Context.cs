using FarukEmlak.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarukEmlak.Controllers
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-1ISDGEM\\MSSQLSERVER02; database=femlak2; integrated security=true; ");
        }

        public DbSet<Kiralik> Kiraliks { get; set; }
        public DbSet<Satilik> Satiliks { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
