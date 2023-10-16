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

namespace _161122_Übung12._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double menge, EndPreis, Prozentsatz, Rabatt, umsatz, Umsatzgrenze = 0, umsatzgrenzeProz = 0, Rabattsum;
            bool ok1, ok2;

            ok1 = Double.TryParse(txtMenge.Text, out menge);
            ok2 = Double.TryParse(txtPreis.Text, out EndPreis);

            if (Umsatzgrenze != 0)
            {
                var comboItem = cmbUmsatzgrenze.SelectedItem as ListBoxItem;
                Umsatzgrenze = Convert.ToDouble(comboItem.Content);
            }

            if (ok1 && ok2)
            {

                umsatz = EndPreis * menge;

                if (umsatz <= Umsatzgrenze)
                {
                    umsatzgrenzeProz = 0;
                }
                else if (umsatz > Umsatzgrenze)
                {
                    umsatzgrenzeProz = 15;
                }

                if (umsatz <= 1000)
                {
                    Prozentsatz = 0;
                }
                else if (umsatz > 100 && umsatz <= 10000)
                {
                    Prozentsatz = 10;
                }
                else
                {
                    Prozentsatz = 20;
                }

                Rabattsum = Prozentsatz + umsatzgrenzeProz;

                Rabatt = umsatz / 100 * Rabattsum;
                EndPreis = umsatz - Rabattsum;

                lblEndPreis.Content = EndPreis;
                lblRabattProzent.Content = Rabattsum;
                lblRabattEuro.Content = Rabatt;
            }
            else
            {
                lblEndPreis.Content = "invalid input";
            }

        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }


    }
}
