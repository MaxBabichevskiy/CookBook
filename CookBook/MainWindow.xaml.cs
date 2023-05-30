using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CookBook.Models;
using CookBook.ViewModels;
using CookBook.Views;

namespace CookBook
{
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainViewModel();
            DataContext = viewModel;
        }

        private void LoadRecipes()
        {
            try
            {
                // Очистить список рецептов перед загрузкой новых данных
                viewModel.Recipes.Clear();

                // Получить список рецептов из базы данных или другого источника данных
                List<Recipe> recipes = recipeRepository.GetRecipes();

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
            // Создать экземпляр окна для добавления рецепта
            RecipeWindow recipeWindow = new RecipeWindow();

            // Создать экземпляр ViewModel для окна добавления рецепта
            RecipeViewModel recipeViewModel = new RecipeViewModel();

            // Установить DataContext окна на созданный ViewModel
            recipeWindow.DataContext = recipeViewModel;

            // Отобразить окно для добавления рецепта
            bool? result = recipeWindow.ShowDialog();

            // Если рецепт успешно добавлен (например, по нажатию кнопки "Сохранить")
            if (result == true)
            {
                // Добавить новый рецепт в список
                viewModel.Recipes.Add(recipeViewModel.Recipe);
            }
        }

        private void EditRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Получить выбранный рецепт из списка
            Recipe selectedRecipe = (Recipe)recipesListBox.SelectedItem;

            if (selectedRecipe != null)
            {
                // Создать экземпляр окна для редактирования рецепта
                RecipeWindow recipeWindow = new RecipeWindow();

                // Создать экземпляр ViewModel для окна редактирования рецепта
                RecipeViewModel recipeViewModel = new RecipeViewModel(selectedRecipe);

                // Установить DataContext окна на созданный ViewModel
                recipeWindow.DataContext = recipeViewModel;

                // Отобразить окно для редактирования рецепта
                bool? result = recipeWindow.ShowDialog();

                // Если рецепт успешно отредактирован (например, по нажатию кнопки "Сохранить")
                if (result == true)
                {
                    // Обновить информацию о рецепте в списке
                    int index = viewModel.Recipes.IndexOf(selectedRecipe);
                    viewModel.Recipes[index] = recipeViewModel.Recipe;
                }
            }
        }

        private void DeleteRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Получить выбранный рецепт из списка
            Recipe selectedRecipe = (Recipe)recipesListBox.SelectedItem;

            if (selectedRecipe != null)
            {
                // Подтвердить удаление рецепта с помощью диалогового окна
                MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите удалить рецепт?", "Подтверждение удаления", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    // Удалить рецепт из списка
                    viewModel.Recipes.Remove(selectedRecipe);
                }
            }
        }

        private void SearchRecipes_Click(object sender, RoutedEventArgs e)
        {
            // Получить текст поиска из текстового поля
            string searchText = txtSearchName.Text;

            // Выполнить поиск рецептов по тексту
            List<Recipe> searchResults = viewModel.Recipes.Where(r => r.Name.Contains(searchText)).ToList();

            // Очистить текущий список рецептов
            viewModel.Recipes.Clear();

            // Добавить результаты поиска в список
            foreach (Recipe recipe in searchResults)
            {
                viewModel.Recipes.Add(recipe);
            }
        }
    }
}
