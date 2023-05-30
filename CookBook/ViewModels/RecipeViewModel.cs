using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CookBook.Models;
using CookBook.ViewModels;

namespace CookBook.ViewModels
{
    public class RecipeViewModel : INotifyPropertyChanged
    {
        private Recipe _recipe;

        public Recipe Recipe
        {
            get { return _recipe; }
            set
            {
                _recipe = value;
                OnPropertyChanged();
            }
        }

        public RecipeViewModel()
        {
            Recipe = new Recipe();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
