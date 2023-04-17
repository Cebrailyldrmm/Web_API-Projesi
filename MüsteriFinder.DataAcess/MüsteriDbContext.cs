using Microsoft.EntityFrameworkCore;
using MüsteriFİnder_Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MüsteriFinder.DataAcess
{
    public class MüsteriDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-AENF83D\\SQLEXPRESS; Database=MüsteriDb;uid=cebrail;pwd=1234;TrustServerCertificate=True");

                
                
        }

        public DbSet<Müsteri> Müsteris { get; set; }

    }
}
