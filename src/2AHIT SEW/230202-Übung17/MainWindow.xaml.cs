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

namespace _230202_Übung17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        Rechteck two = new Rechteck();
        Kreis one = new Kreis();

        private void cboDes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public MainWindow()
        { 
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            bool ok3;
            var comboItem = cboDes.Uid;
            int Uid;

            ok3 = Int32.TryParse(comboItem, out Uid); //kreis uid=2; rechteck uid=1;

            if (Uid == 1)
            {
               
                txtRad.IsEnabled = false;
                double a, b;
                bool ok1, ok2;


                ok1 = Double.TryParse(txtA.Text, out a);
                ok2 = Double.TryParse(txtB.Text, out b);


                two.len = a;
                two.with = b;
                if (a < 0 && b < 0)
                {
                    two.Lenght();
                    two.Width();
                    lblCirc.Content = two.GetCircumference();
                    lblArea.Content = two.GetArea();
                }
                else if( a>=0 && b>=0)
                {
                    lblCirc.Content = two.GetCircumference();
                    lblArea.Content = two.GetArea();
                }

            }
            else if (Uid == 2)
            {
                txtA.IsEnabled = false;
                txtB.IsEnabled = false;

                bool ok1;
                double r;


                ok1 = Double.TryParse(txtRad.Text, out r);

                one.radius = r;
                if (r < 0)
                {
                    one.Radius();
                    lblCirc.Content =  one.GetCircumference();
                    lblArea.Content = one.GetArea();
                }
                else if (r <= 0)
                {
                    lblCirc.Content = one.GetCircumference();
                    lblArea.Content = one.GetArea();
                }
                
            }
        }

    }
}
