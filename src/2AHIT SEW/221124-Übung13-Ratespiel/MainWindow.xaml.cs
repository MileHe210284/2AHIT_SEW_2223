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

namespace _221124_Übung13_Ratespiel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i;
        int random;
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            bool ok1;
            int number;
            
            
            ok1 = int.TryParse(txtZahl.Text, out number);

            if (number > random)
            {
                i++;
                lblPrüfung.Content = "You guesset too high";
            }
            else if (number < random)
            {
                i++;
                lblPrüfung.Content = "your guess it too low";
            }
            else
            {
                lblPrüfung.Content = "richtig";
                btnCheck.IsEnabled = false;
                txtZahl.IsEnabled = false;

            }
            
            lblVersuche.Content = i;
       
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            random = RandomNumber(1, 100);
            initilizeUI(true);
           

            
        }
        private void initilizeUI(bool isEnabed)
        {
            btnCheck.IsEnabled = isEnabed;
            txtZahl.IsEnabled = isEnabed;
            i = 0;
            lblPrüfung.Content = "---";
            lblVersuche.Content = 0;
            txtZahl.Text = " ";

        }

    }
}
