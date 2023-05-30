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



        private async void LoadRecipes() // Изменяем метод на асинхронный
        {
            try
            {
                // Очистить список рецептов перед загрузкой новых данных
                viewModel.Recipes.Clear();

                // Получить список рецептов из базы данных или другого источника данных
                List<Recipe> recipes = await recipeRepository.GetRecipesAsync();
                // Используем асинхронный метод

                // Добавить полученные рецепты в список
                foreach (Recipe recipe in recipes)
                {
                    viewModel.Recipes.Add(recipe);
                }
            }
            catch (Exception ex)
            {
                // Обработка исключения при загрузке рецептов
                // Можно вывести сообщение об ошибке или выполнить другие действия
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
                // Логика удаления рецепта
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
