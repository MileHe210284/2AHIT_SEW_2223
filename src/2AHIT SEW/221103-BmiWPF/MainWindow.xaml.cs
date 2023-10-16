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

namespace _221103_BmiWPF
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

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double weight, height,multiplikator;

            bool ok1, ok2;

            ok1 = Double.TryParse(txtHeight.Text, out height);
            ok2 = Double.TryParse(txtWeight.Text, out weight);

            if (ok1 && ok2)
            {
                double bmi = weight / Math.Pow(height, 2);
                if (txtGender.Text == "m")
                {
                    multiplikator = 0.95;
                }
                else
                {
                    multiplikator = 0.9;
                }

                if (bmi >= 16 && bmi <= 17)
                {
                    lblBMI.Content="untergewicht";
                }
                else if (bmi <= 18.5)
                {
                    lblBMI.Content = "Leichtes untergewicht";
                }
                else if (bmi <= 25 * multiplikator)
                {
                    lblBMI.Content ="Normalgewicht";
                }
                else if (bmi <= 30)
                {
                    lblBMI.Content = "Praeadipositas";
                }
                else if (bmi <= 35)
                {
                    lblBMI.Content = "Adipositas Grad 1";
                }
                else if (bmi <= 40)
                {
                    lblBMI.Content = "Adipositas Grad 2";
                }
                else if (bmi > 40)
                {
                    lblBMI.Content = "Adipositas Grad 3";
                }
                else
                {
                    lblBMI.Content = "Starkes Untergewicht";
                }
                lblBmiNumber.Content =  bmi;
            }
            else
            {
                lblBMI.Content = "Fehlerhafte eingabe";
            }
        }
    }
}
