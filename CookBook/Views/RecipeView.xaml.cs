using CookBook.ViewModels;
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
    /// Логика взаимодействия для RecipeView.xaml
    /// </summary>
    public partial class RecipeView : Window
    {
        public RecipeView()
        {
            InitializeComponent();
        }

        public RecipeView(RecipeViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
