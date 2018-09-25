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

namespace WpfApp4
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

        private void btn_Scrol(object sender, RoutedEventArgs e)
        {
            string lable1 = Lable_1.Content.ToString();
            Lable_1.Content = Lable_2.Content;
            Lable_2.Content = Lable_3.Content;
            Lable_3.Content = Lable_4.Content;
            Lable_4.Content = lable1;
        }
        private void btn_Clear(object sender, RoutedEventArgs e)
        {

        }
        private void btn_Scrol_Down(object sender, RoutedEventArgs e)
        {

        }
    }
}
