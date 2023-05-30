using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using CookBook.Models;
using Prism.Commands;
using Prism.Mvvm;

namespace CookBook.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly CookBookContext _context;

        public MainViewModel()
        {
            _context = new CookBookContext();
            LoadRecipes();
        }


        private ObservableCollection<Recipe> _recipes;
        public ObservableCollection<Recipe> Recipes
        {
            get { return _recipes; }
            set { SetProperty(ref _recipes, value); }
        }

        private Recipe _selectedRecipe;
        public Recipe SelectedRecipe
        {
            get { return _selectedRecipe; }
            set { SetProperty(ref _selectedRecipe, value); }
        }

        public DelegateCommand AddRecipeCommand => new DelegateCommand(AddRecipe);
        public DelegateCommand UpdateRecipeCommand => new DelegateCommand(UpdateRecipe, CanUpdateOrDeleteRecipe);
        public DelegateCommand DeleteRecipeCommand => new DelegateCommand(DeleteRecipe, CanUpdateOrDeleteRecipe);

        public void LoadRecipes()
        {
            Recipes = new ObservableCollection<Recipe>(_context.Recipes.ToList());
        }

        private void AddRecipe()
        {
            // Логика добавления нового рецепта
        }

        private void UpdateRecipe()
        {
            // Логика обновления выбранного рецепта
        }

        private bool CanUpdateOrDeleteRecipe()
        {
            return SelectedRecipe != null;
        }

        private void DeleteRecipe()
        {
            // Логика удаления выбранного рецепта
        }
    }
}
