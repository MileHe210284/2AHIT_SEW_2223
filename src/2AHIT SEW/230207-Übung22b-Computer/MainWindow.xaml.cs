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

namespace _230207_Übung22b_Computer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MathOperations math = new MathOperations();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {

            bool ok1, ok2;
            double a, b;

            ok1 = Double.TryParse(txtA.Text, out a);
            ok2 = Double.TryParse(txtB.Text, out b);



            if (ok1 && ok2)
            {
                if (rdoAdd.IsChecked == true)
                {
                    lblResult.Content = math.Add();

                }
                else if (rdoDevide.IsChecked == true)
                {
                    lblResult.Content = math.Devide();

                }
                else if (rdoSubtract.IsChecked == true)
                {
                    lblResult.Content = math.Subtract();

                }
                else if (rdoMultiply.IsChecked == true)
                {
                    lblResult.Content = math.Multiply();

                }
            }

            else { lblResult.Content = "invalid input"; }
        }

        private void Betrag_Click(object sender, RoutedEventArgs e)
        {
            bool ok1;
            double zahl;

            ok1 = Double.TryParse(txtBetrag.Text, out zahl);


            if (rdoSignum.IsChecked == true)
            {
                lblBetrag.Content = math.Signum(zahl);

            }
            else if (rdoBetrag.IsChecked == true)
            {
                lblBetrag.Content = math.Abs(zahl);
            }
        }

    }
}
