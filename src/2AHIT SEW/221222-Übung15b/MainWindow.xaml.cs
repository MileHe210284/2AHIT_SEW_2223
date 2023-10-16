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

namespace _221222_Übung15b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double Mittelwert(double[] number, double anz, int i, out double mw)
        {
            
            mw = 0;
           
            if(i >=0) 
            {
                mw = anz/i;
            }
            else
            {
                mw = 0 ;
            }
            
            return mw;
        }
       

        double[] number = new double[20];
        int i = 0;
        public MainWindow()
        {

            InitializeComponent();

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            bool ok1, ok2;
            double anz = 0; //addition von allen eingegebenen zahlen
            double mw; //mittelwert

            double numb; // speichern der eingegebenen zahlen

        

            ok1 = Double.TryParse(txtEingabe.Text, out number[i]);
            ok2 = Double.TryParse(txtEingabe.Text, out numb);

            if (ok1)
            { 
                listBox1.Items.Add(number[i]);
                numb = number[i];
                anz = numb + anz;
                i++;
            }
            mw = Mittelwert(number, anz, i, out mw);
            if (i >= 20)
            {
                txtInfo.Text = "zu viele zahlen!";
                btnAdd.IsEnabled = false;
            }
            lblMittel.Content = mw;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.RemoveAt(0);
            btnAdd.IsEnabled = true;
            i--;
            txtInfo.Text = " ";
            if (i == 0)
            {
                btnDelete.IsEnabled = false; 
            }
        }
    }
}
