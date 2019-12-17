using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for ghana.xaml
    /// </summary>
    /// 
    public partial class ghana : Window
    {
        int[] arr = new int[12];
        string[] array1 = new string[12];
        bool result;
       
        public ghana()
        {
            InitializeComponent();
            result = true;
            tempLoad();
            loaded();
            windload();
        }
        public void tempLoad()
        {
            // OpenFileDialog theDialog = new OpenFileDialog();
            //theDialog.Title = "Open Text File";
            //theDialog.Filter = "TXT files|*.txt";
            //theDialog.InitialDirectory = @"Desktop";
            //Nullable<bool> result = theDialog.ShowDialog();
            // filelabel.Content = theDialog.FileName;
            string filename = @"C:\Users\hp\source\repos\WeatherApp_wpf\WeatherApp_wpf\bin\Debug\ghana.txt"; ;
            if (result == true)
            {

                using (StreamReader sr = new StreamReader(filename))
                {
                    int i = 0;
                    foreach (string line in File.ReadAllLines(filename))
                    {
                        if (line == "")
                        {
                            break;
                        }

                        else
                        {
                            string[] parts = line.Split('-');

                            foreach (string part in parts)
                            {
                                Console.WriteLine(part);
                                //  Console.WriteLine(arr[i] = part);
                                //int a = Convert.ToInt32(part);
                                array1[i] = part;
                                i++;
                            }

                            //  Console.WriteLine(array2[i]);
                            // For demonstration.
                        }

                    };
                }
            }
        }
        double[] arr2 = new double[12];
        public void loaded()
        {

            jan.Content = array1[0];
            feb.Content = array1[1];
            mar.Content = array1[2];
            april.Content = array1[3];
            may.Content = array1[4];
            june.Content = array1[5];
            july.Content = array1[6];
            aug.Content = array1[7];
            sep.Content = array1[8];
            oct.Content = array1[9];
            nov.Content = array1[10];
            dec.Content = array1[11];
            for (int i = 0; i < array1.Length; i++)
            {
                arr2[i] = Convert.ToDouble(array1[i]);

            }
            double s = arr2.Max();
            mxtemp.Content = s.ToString();
            double f = arr2.Min();
            mintemp.Content = f.ToString();
            double avg = arr2.Average();
            double ex = Math.Round(avg, 4);
            avgTemp.Content = ex.ToString();
        }


        /* private void Load_Click(object sender, RoutedEventArgs e)
         {
             tempLoad();
             loaded();
             windload();
         }*/
        double[] wind = new double[12];
        public void windload()
        {
           

            //  OpenFileDialog theDialog = new OpenFileDialog();
            // theDialog.Title = "Open Text File";
            //theDialog.Filter = "TXT files|*.txt";
            //theDialog.InitialDirectory = @"Desktop\ireland_wind.txt";
            //Nullable<bool> result = theDialog.ShowDialog();
            // filelabel.Content = theDialog.FileName;
            string filename = @"C:\Users\hp\source\repos\WeatherApp_wpf\WeatherApp_wpf\bin\Debug\ghanawind.txt";

            if (result == true)
            {

                using (StreamReader sr = new StreamReader(filename))
                {
                    int i = 0;
                    foreach (string line in File.ReadAllLines(filename))
                    {
                        if (line == "")
                        {
                            break;
                        }

                        else
                        {
                            string[] parts = line.Split('-');

                            foreach (string part in parts)
                            {
                                Console.WriteLine(part);
                                //  Console.WriteLine(arr[i] = part);
                                double a = Convert.ToDouble(part);
                                wind[i] = a;
                                i++;
                            }

                            //  Console.WriteLine(array2[i]);
                            // For demonstration.
                        }

                    };
                }
            }


            double f = wind.Average();
            double ex = Math.Round(f, 4);
            avgWind.Content = ex.ToString();
            double max = wind.Max();
            maxWind.Content = max.ToString();
            double min = wind.Min();
            minWind.Content = min.ToString();

        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {

            MainWindow mp = new MainWindow();
            mp.Show();
            this.Hide();
        }

        private void Abovetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                double enter = Convert.ToDouble(abovetxt.Text);
                int count = 0;

                for (int i = 0; i < arr2.Length; i++)
                {
                    if (arr2[i] > enter)
                    {
                        count++;
                    }
                }
                caltempAbove.Content = count.ToString();
            }
        }

        private void TempBelowtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                double enter = Convert.ToDouble(tempBelowtxt.Text);
                int count = 0;

                for (int i = 0; i < arr2.Length; i++)
                {
                    if (arr2[i] < enter)
                    {
                        count++;
                    }
                }
                caltempbelow.Content = count.ToString();
            }
        }

        private void WindAbovetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                double enter = Convert.ToDouble(windAbovetxt.Text);
                int count = 0;

                for (int i = 0; i < arr2.Length; i++)
                {
                    if (wind[i] > enter)
                    {
                        count++;
                    }
                }
                calWindAbove.Content = count.ToString();
            }
        }

        private void WindBelowtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                double enter = Convert.ToDouble(windBelowtxt.Text);
                int count = 0;

                for (int i = 0; i < arr2.Length; i++)
                {
                    if (wind[i] < enter)
                    {
                        count++;
                    }
                }
                calWindBelow.Content = count.ToString();
            }
        }
    }
}
