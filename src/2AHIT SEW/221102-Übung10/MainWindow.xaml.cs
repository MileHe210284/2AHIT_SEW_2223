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

namespace _221102_Übung10
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
            double height, width, lenght, volume, surface;
            bool ok1, ok2, ok3;

            ok1 = Double.TryParse(txtHeight.Text, out height);
            ok2 = Double.TryParse(txtWidth.Text, out width);
            ok3 = Double.TryParse(txtLenght.Text, out lenght);

            if (ok1 && ok2 && ok3)
            {
                volume = height * width * lenght;
                lblVolume.Content = volume.ToString();

                surface = 2 * lenght * width + 2 * lenght * height + 2 * width * height;
                lblSurface.Content = surface.ToString();
            }
            else
            {
                lblVolume.Content = "invalid input";
            }
        }
    }
}
