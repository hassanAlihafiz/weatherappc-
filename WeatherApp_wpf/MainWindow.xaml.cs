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

namespace WeatherApp_wpf
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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Pak_Click(object sender, RoutedEventArgs e)
        {
            scotland p = new scotland();
            p.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            p.Show();
            this.Hide();
        }

        private void Ind_Click(object sender, RoutedEventArgs e)
        {
            ireland i = new ireland();
            i.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            i.Show();
            this.Hide();
        }

        private void Sri_Click(object sender, RoutedEventArgs e)
        {
            ghana sr = new ghana();
            sr.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            sr.Show();
            this.Hide();

        }

        private void Pakistan_Click(object sender, RoutedEventArgs e)
        {

        }

        private void India_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
