using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int Quantity { get; set; }
    }
}
