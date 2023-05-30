using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;





namespace CookBook.Models
{
    public class CookBookContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Step> Steps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = MSI; Initial Catalog = Accounting; Trusted_Connection=True; Encrypt=False"); // Замените "YourConnectionString" на вашу строку подключения к базе данных
        }
    }
}
