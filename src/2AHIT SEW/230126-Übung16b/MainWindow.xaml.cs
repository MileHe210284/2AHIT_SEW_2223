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

namespace _230126_Übung16b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        Rechteck two = new Rechteck();
        Kreis one = new Kreis();
        bool x, y;

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
            var comboItem = cboDes.Uid ;
            int Uid;

            ok3= Int32.TryParse(comboItem, out Uid); //kreis uid=1; rechteck uid=2;

            if(Uid == 1)
            {
                txtA.IsEnabled = false;
                txtB.IsEnabled = false;

                double a, b;
                bool ok1, ok2, ok4, ok5;

                ok1 = Double.TryParse(txtA.Text, out a);
                ok2 = Double.TryParse(txtB.Text, out b);
                ok4 = Double.TryParse(txtYm.Text, out y);
                ok5 = Double.TryParse(txtXm.Text, out x);


                two.len = a;
                two.with = b;

                lblCirc.Content = two.GetCircumference();
                lblArea.Content = two.GetArea();
               
            } 
            else if(Uid == 2)
            {
                txtRad.IsEnabled = false;
               

                bool ok1, ok2, ok4;
                double r;
                

                ok1 = Double.TryParse(txtRad.Text, out r);
                ok2 = Double.TryParse(txtXm.Text, out x);
                ok4 = Double.TryParse(txtYm.Text, out y);

                one.radius = r;

                lblCirc.Content = one.GetCircumference();
                lblArea.Content = one.GetArea();

            }
        }
    
    }
}
