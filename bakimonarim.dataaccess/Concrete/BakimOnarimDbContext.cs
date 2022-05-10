
using bakimonarim.entity;
using bakimonarim.entity.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakimonarim.dataaccess.Concrete
{
    public class BakimOnarimDbContext : IdentityDbContext
    {
        
        public DbSet<Varlik2> TBL_Varlik { get; set; }
        public DbSet<VGrup> TBL_VGrup { get; set; }
        public DbSet<Malzeme> TBL_Malzeme {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=bakimonarimdbexample;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=bakimonarimdb;Uid=root;Pwd=root;");
        //}

    }
}
