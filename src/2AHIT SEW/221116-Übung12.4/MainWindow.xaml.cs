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

namespace _221116_Übung12._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void ComputePrice(double p,double Umsatzgrenze,double umsatz,double EPreis, double menge, double umsatzgrenzeProz, out double EndPreis, out double Rabatt, out double Rabattsum)
        {
           
                umsatz = EPreis * menge;

                if (umsatz <= Umsatzgrenze)
                {
                    umsatzgrenzeProz = 0;
                }
                else if (umsatz > Umsatzgrenze)
                {
                    umsatzgrenzeProz=p;
                }

                Rabattsum = umsatzgrenzeProz;
                Rabatt = umsatz / 100 * Rabattsum;
                EndPreis = umsatz - Rabattsum;
            
        }

        private double getDiscountInPercent()
        {
            double p = 0;

            if (rdoMin.IsChecked == true)
            {
                p = 0;
            }
            if (rdoMidle.IsChecked == true)
            {
                p = 10;
            }
            if (rdoMax.IsChecked == true)
            {
                p = 20;
            }
            return p;
        }


        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double menge, EndPreis=0, Rabatt, umsatz=0, Umsatzgrenze = 0, umsatzgrenzeProz = 0, Rabattsum=0, p=0, EPreis=0;
            bool ok1, ok2;

            ok1 = Double.TryParse(txtMenge.Text, out menge);
            ok2 = Double.TryParse(txtPreis.Text, out EPreis);

            p = getDiscountInPercent();

            if (Umsatzgrenze != 0)
            {
                var comboItem = cmbUmsatzgrenze.SelectedItem as ComboBoxItem;
                Umsatzgrenze = Convert.ToDouble(comboItem.Content);
            }

              ComputePrice(p,Umsatzgrenze,umsatz, EPreis, menge, umsatzgrenzeProz, out EndPreis, out Rabatt, out Rabattsum);

              lblEndPreis.Content = EndPreis;
              lblRabattProzent.Content = Rabattsum;
              lblRabattEuro.Content = Rabatt;
         

        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }
        
    }
}
