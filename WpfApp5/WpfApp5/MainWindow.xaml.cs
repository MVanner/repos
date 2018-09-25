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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Line1 = Line_1.Text.ToString();
            Line_1.Text = Line_2.Text;
            Line_2.Text = Line_3.Text;
            Line_3.Text = Line_4.Text;
            Line_4.Text = Line1;

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Line_1.Text = "";
            Line_2.Text = "";
            Line_3.Text = "";
            Line_4.Text = "";
        }

        private void Scrol_Down_Click(object sender, RoutedEventArgs e)
        {
            string Line4 = Line_4.Text.ToString();
            Line_4.Text = Line_3.Text;
            Line_3.Text = Line_2.Text;
            Line_2.Text = Line_1.Text;
            Line_1.Text = Line4;
        }
    }
}
