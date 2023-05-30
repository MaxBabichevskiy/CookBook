using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CookBook.Views
{
    /// <summary>
    /// Логика взаимодействия для RecipeWindow.xaml
    /// </summary>
    public partial class RecipeWindow : Window
    {
        public RecipeWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // Логика обработки события нажатия на кнопку "Add"
            // Получение введенных значений из текстовых полей и комбо-бокса
            string recipeName = txtRecipeName.Text;
            string category = cmbCategory.Text;
            string ingredients = txtIngredients.Text;
            string instructions = txtInstructions.Text;

            // Выполнение дополнительных действий, таких как добавление рецепта в базу данных или коллекцию

            // Закрытие окна после выполнения операции
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            // Логика обработки события нажатия на кнопку "Cancel"
            // Закрытие окна без выполнения каких-либо дополнительных действий
            Close();
        }
    }
}
