using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Ex51_ThreadsInWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool SensorsRunning = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread hygge = new Thread(() => Sensor(Hygge1));
            hygge.Start();
            Thread hygge2 = new Thread(() => Sensor(Hygge2));
            hygge.Start();
            Thread hygge3 = new Thread(() => Sensor(Hygge3));
            hygge.Start();
            Thread hygge4 = new Thread(() => Sensor(Hygge4));
            hygge.Start();
            Thread hygge5 = new Thread(() => Sensor(Hygge5));
            hygge.Start();
            Thread hygge6 = new Thread(() => Sensor(Hygge6));
            hygge.Start();
            Thread hygge7 = new Thread(() => Sensor(Hygge7));
            hygge.Start();
            Thread hygge8 = new Thread(() => Sensor(Hygge8));
            hygge.Start();
            Thread hygge9 = new Thread(() => Sensor(Hygge9));
            hygge.Start();
            Thread hygge10 = new Thread(() => Sensor(Hygge10));
            hygge.Start();

        }

        private void Sensor(Object o)
        {
            Label l = (Label)o;
            Random r = new Random();
            while (SensorsRunning)
            {
                Thread.Sleep(1000);
                double temp = 10 + r.NextDouble() * 15;

                //tilføj kode her som overfører temp til vinduets label
                l.Dispatcher.Invoke(new Action(() => l.Content = temp));
                
            }
        }
    }
}
