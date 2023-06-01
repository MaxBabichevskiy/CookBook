using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CookBook.Models;
using CookBook.ViewModels;
using CookBook.Views;

namespace CookBook
{
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;
        private RecipeRepository recipeRepository;
        private readonly CookBookContext context;

        public MainWindow()
        {
            InitializeComponent();

            context = new CookBookContext();
            recipeRepository = new RecipeRepository(context);

            DataContext = new MainViewModel(context, recipeRepository);
        }



        private async void LoadRecipes()
        {
            try
            {
                // Очистить список рецептов перед загрузкой новых данных
                viewModel.Recipes.Clear();

                // Получить список рецептов из базы данных или другого источника данных
                List<Recipe> recipes = await recipeRepository.GetRecipesAsync();

                // Добавить полученные рецепты в список
                foreach (Recipe recipe in recipes)
                {
                    viewModel.Recipes.Add(recipe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading recipes: {ex.Message}");
            }
        }


        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Открываем окно для добавления рецепта
            RecipeWindow recipeWindow = new RecipeWindow();
            recipeWindow.DataContext = new RecipeViewModel();
            recipeWindow.ShowDialog();
            recipeWindow.Show();


            // После закрытия окна можно выполнить необходимые действия
            // Например, обновить список рецептов
            LoadRecipes();
        }

        private void EditRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, есть ли выбранный рецепт
            if (viewModel.SelectedRecipe != null)
            {
                // Открываем окно для редактирования рецепта
                RecipeWindow recipeWindow = new RecipeWindow();
                recipeWindow.DataContext = new RecipeViewModel(viewModel.SelectedRecipe);
                recipeWindow.ShowDialog();

                // После закрытия окна можно выполнить необходимые действия
                // Например, обновить список рецептов
                LoadRecipes();
            }
        }

        private void DeleteRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, есть ли выбранный рецепт
            if (viewModel.SelectedRecipe != null)
            {
                // Показываем диалоговое окно подтверждения удаления
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this recipe?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    // Удаляем выбранный рецепт из базы данных
                    recipeRepository.DeleteRecipe(viewModel.SelectedRecipe);

                    // Обновляем список рецептов
                    LoadRecipes();
                }
            }
        }


        private void SearchRecipes_Click(object sender, RoutedEventArgs e)
        {
            // Логика поиска рецептов
        }

        private void txtSearchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Логика поиска рецептов по названию
        }
    }
}
