using bakimonarim.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakimonarim.dataaccess.Concrete
{
    public class BakimOnarimDbContext : DbContext
    {
        public DbSet<Varlik> TBL_Varlik { get; set; }
        public DbSet<VGrup> TBL_VGrup { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=bakimonarimdb;Trusted_Connection=True;");

        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=bakimonarimdb;Uid=root;Pwd=root;");
        //}

    }
}
