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
using mvvm.ViewModels;

namespace mvvm.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FirstNameText.Text = MainViewModel.Instance.ImportantPerson.FirstName;
            LastNameText.Text = MainViewModel.Instance.ImportantPerson.LastName;
            FullNameTextBlock.Text = MainViewModel.Instance.ImportantPerson.FullName;
        }

        private void Gem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
