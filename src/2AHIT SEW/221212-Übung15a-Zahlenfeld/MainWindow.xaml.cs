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

namespace _221212_Übung15a_Zahlenfeld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] number = new double[20];
        int i = 0;
        public MainWindow()
        {
           
            InitializeComponent();
           
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            
         bool ok1;


         ok1 = Double.TryParse(txtEingabe.Text, out number[i]);
            if (ok1)
            {

                listBox1.Items.Add(number[i]);
                i++;
            } 
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.RemoveAt(0);
        }
    }
}
