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

namespace Übung15c
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Mittelwert(double[] number, int anzahl, double n, out double mw)
        {

            mw = 0;
            if (0 <= n && n < anzahl && anzahl <= number.Length)
            {
                for (int p = 0; p < i; p++)
                {
                    mw = mw + number[p];
                }
                mw = mw / i;
                return true;
            }
            else
            {
                return false;
            }
        }

        bool Max(double[] number, int anzahl, double n, out double max)
        {
            max = number[i];
            if (0 <= n && n < anzahl && anzahl <= number.Length)
            {
                for (int p = 0; p < i; p++)
                {
                    if (max < number[p])
                    {
                        max = number[p];
                    }
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        bool Minimum(double[] number,int anzahl, double n, out double min)
        {
            min = number[0];
            if (0 <= n && n < anzahl && anzahl <= number.Length)
            {
                for (int p = 0; p < i; p++)
                {
                    if (min > number[p])
                    {
                        min = number[p];
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        double[] number = new double[20];
        int i = 0;
        double n ;
        int anzahl;
        public MainWindow()
        {

            InitializeComponent();

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            bool ok1, ok2;

            double mw; 
            double max;
            double min;
           
            ok1 = Double.TryParse(txtEingabe.Text, out number[i]);
            ok2 = Double.TryParse(txtn.Text, out n);

            if (ok1)
            {
                listBox1.Items.Add(number[i]);
                n++;
                i++;
                anzahl++;
            }

            Mittelwert(number, anzahl, n, out mw);
            Max(number, anzahl, n, out max);
            Minimum(number, anzahl, n, out min);

            if (n <= 20)
            {
                lblMittel.Content = Convert.ToString(mw);
                lblMax.Content = Convert.ToString(max);
                lblMin.Content = Convert.ToString(min);

            }
            else
            {
                txtInfo.Text = "zu viele zahlen!";
                btnAdd.IsEnabled = false;
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.RemoveAt(0);
            btnAdd.IsEnabled = true;
            i--;
            n--;
            txtInfo.Text = " ";
            if (i == 0)
            {
                btnDelete.IsEnabled = false;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();

            number[i] = 0;

        }
    }
}