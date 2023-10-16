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

namespace _221103_Übung11
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
            double x, y, radius;
            bool ok1, ok2, ok3;

            ok1 = Double.TryParse(txtRadius.Text, out radius);
            ok2 = Double.TryParse(txtY.Text, out y);
            ok3 = Double.TryParse(txtX.Text, out x);

            if (ok1 && ok2 && ok3)
            {
                double distance = Math.Sqrt(Math.Pow(x, 2) * Math.Pow(y, 2));
                if (distance < radius)
                {
                   lblLengh.Content="the point is in the circle";
                }
                else if (distance == radius)
                {
                    lblLengh.Content = "the point is on the border of the circle";
                }
                else if (distance > radius)
                {
                    lblLengh.Content = "the point is outside of the circle";
                }
            }
            else
            {
                lblLengh.Content = "invalid input";
            }

        }


        
    }
}
