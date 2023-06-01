using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models
{
    public class Step
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public int RecipeId { get; set; }
        public int StepNumber { get; set; }
        public Recipe Recipe { get; set; }
    }
}
