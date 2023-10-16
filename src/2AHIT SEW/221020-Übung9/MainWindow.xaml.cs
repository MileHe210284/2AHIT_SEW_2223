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

namespace _221020_Übung9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Sum_Click(object sender, RoutedEventArgs e)
        {

            double numb1, numb2, sum;
            bool ok1, ok2;

            ok1 = Double.TryParse(txtZahl1.Text, out numb1);
            ok2 = Double.TryParse(txtZahl2.Text, out numb2);

            if (ok1 == true && ok2 == true)
            {

                sum = numb1 + numb2;
                lblSum.Content = sum;
            }
            else
            {
                lblSum.Content = "invalid input";
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }
    }
}
