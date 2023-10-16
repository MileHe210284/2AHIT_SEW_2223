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

namespace Übung_14_quadratischeGleichung
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
        public double[] compute(double a, double b, double c)
        {
            double d = (b * b) - 4 * a * c;
            double[] calc = new double[2];

            if (d  > 0)
            {
                calc[0] = (-b + Math.Sqrt(d)) / (2 * a);
                calc[1] = (-b - Math.Sqrt(d)) / (2 * a);
            }
            else if (d  == 0)
            {
                calc[0] = (-b / (2 * a));
                calc[1] = (-b / (2 * a));
            }
            else if (d  < 0)
            {
                calc[0] = 0;
                calc[1] = 0;
            }

            return calc;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;
            bool ok1 ,ok2, ok3;
            double[] calc;

            ok1 = Double.TryParse(txtA.Text, out a);
            ok2 = Double.TryParse(txtB.Text, out b);
            ok3 = Double.TryParse(txtC.Text, out c);

            calc = compute(a, b, c);

            lblx1.Content = calc[0];
            lblx2.Content = calc[1];

        }
    }
}
