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
        private RecipeRepository _recipeRepository;
        public MainViewModel(CookBookContext context, RecipeRepository recipeRepository)
        {
            _context = context;
            _recipeRepository = recipeRepository;
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

        private string _newRecipeName;
        public string NewRecipeName
        {
            get { return _newRecipeName; }
            set
            {
                _newRecipeName = value;
                OnPropertyChanged(nameof(NewRecipeName));
            }
        }

        private string _newRecipeType;
        public string NewRecipeType
        {
            get { return _newRecipeType; }
            set
            {
                _newRecipeType = value;
                OnPropertyChanged(nameof(NewRecipeType));
            }
        }

        private string _newRecipeCuisine;
        public string NewRecipeCuisine
        {
            get { return _newRecipeCuisine; }
            set
            {
                _newRecipeCuisine = value;
                OnPropertyChanged(nameof(NewRecipeCuisine));
            }
        }

        private string _newRecipeIngredients;
        public string NewRecipeIngredients
        {
            get { return _newRecipeIngredients; }
            set
            {
                _newRecipeIngredients = value;
                OnPropertyChanged(nameof(NewRecipeIngredients));
            }
        }

        private string _newRecipeSteps;
        public string NewRecipeSteps
        {
            get { return _newRecipeSteps; }
            set
            {
                _newRecipeSteps = value;
                OnPropertyChanged(nameof(NewRecipeSteps));
            }
        }

        private void AddRecipe()
        {
            // Логика добавления нового рецепта

            // Создание нового рецепта
            Recipe newRecipe = new Recipe
            {
                Name = NewRecipeName, // Предполагается, что у вас есть свойство NewRecipeName, содержащее название нового рецепта
                Type = NewRecipeType, // Предполагается, что у вас есть свойство NewRecipeType, содержащее тип нового рецепта
                Cuisine = NewRecipeCuisine, // Предполагается, что у вас есть свойство NewRecipeCuisine, содержащее кухню нового рецепта
            };

            // Добавление ингредиентов в новый рецепт
            foreach (var ingredientText in NewRecipeIngredients.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                var ingredientParts = ingredientText.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (ingredientParts.Length == 2)
                {
                    string ingredientName = ingredientParts[0].Trim();
                    string ingredientQuantity = ingredientParts[1].Trim();

                    Ingredient newIngredient = new Ingredient
                    {
                        Name = ingredientName
                    };

                    newRecipe.Ingredients.Add(newIngredient);
                }
            }

            // Добавление шагов приготовления в новый рецепт
            int stepNumber = 1;
            foreach (var stepText in NewRecipeSteps.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                Step newStep = new Step
                {
                    StepNumber = stepNumber,
                    Description = stepText.Trim()
                };

                newRecipe.Steps.Add(newStep);
                stepNumber++;
            }

            // Добавление нового рецепта в список рецептов
            Recipes.Add(newRecipe);

            // Сброс значений свойств нового рецепта
            NewRecipeName = string.Empty;
            NewRecipeType = string.Empty;
            NewRecipeCuisine = string.Empty;
            NewRecipeIngredients = string.Empty;
            NewRecipeSteps = string.Empty;
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
