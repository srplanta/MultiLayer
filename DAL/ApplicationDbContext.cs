using BOL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Add following NuGet packages in DAL project also
//  1. Microsoft.EntityFrameworkCore
//  2. Microsoft.EntityFrameworkCore.Design
//  3. Microsoft.EntityFrameworkCore.SqlServer
//  4. Microsoft.EntityFrameworkCore.Tools
namespace DAL
{
    public class ApplicationDbContext : DbContext   //DbContext requires Microsoft.EntityFrameworkCore
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"server=DESKTOP-MAE99H0; database=MultiLayerDb; trusted_connection=true;encrypt=false;TrustServerCertificate=true;");
        }

        //Add reference of each model class from BOL project
        public DbSet<Category> Category { get; set; }
    }
}
