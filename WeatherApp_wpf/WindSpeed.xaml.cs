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

namespace WeatherApp_wpf
{
    /// <summary>
    /// Interaction logic for WindSpeed.xaml
    /// </summary>
    public partial class WindSpeed : Window
    {
        public WindSpeed()
        {
            InitializeComponent();
        }

        private void Cal_Click(object sender, RoutedEventArgs e)
        {
            double txt = Convert.ToDouble(txtinput.Text);
            //convert into mph
            double mph = txt * 0.621371;
            double mph1 = Math.Round(mph, 4);
            //Convert Your input into mph
            convertLabel.Content = "Convert Your Input Into Mph " + mph1;
            //mph * 5280feet
            double s = mph * 5280;
            double s1 = Math.Round(s, 4);
            feetperhour.Content = s1 + " " + "Feet Per Hour";
            //528,000 feet per hour/6,080 feet=knots
            double h = s / 6080;
            double h1 = Math.Round(h, 4);
            Knots.Content = "Wind Speed is" + " " + h1 + " " + "Knots";
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ghana p = new ghana();
            p.Show();
            this.Hide();
        }
    }
}
