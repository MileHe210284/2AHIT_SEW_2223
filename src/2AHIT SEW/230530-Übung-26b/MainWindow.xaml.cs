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

namespace _230530_Übung_26b
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

        double currentSpeed;

        Fortbewegungsmittel f = new Fortbewegungsmittel();

        Boot boot = new Boot(true , 275.97, 1);
        Flugzeug flugzeug = new Flugzeug(60.93);
        PKWmitMotor pkw = new PKWmitMotor(5, "W12345u", 68.9, 4, 120.5, 500, "winter", "Drumm brakes", "Super");
        Fahrrad fahrrad = new Fahrrad("mountain", 21, 2, 0);

        private void UpdateDisplay(Fortbewegungsmittel f)
        {
            if (f != null)
            {
                if (f.HasEngine)
                {
                    btnStart.IsEnabled = true;
                    btnStop.IsEnabled = true;
                    rdoRunning.IsEnabled = false;
                    rdoStopped.IsEnabled = false;
                }
                else
                {
                    btnStart.IsEnabled = false;
                    btnStop.IsEnabled = false;
                    rdoRunning.IsEnabled = false;
                    rdoStopped.IsEnabled = false;
                }
            }
        }

        private void Boot_Checked(object sender, RoutedEventArgs e)
        {
            f = boot;
            UpdateDisplay(f);
        }
        private void Fahrrad_Checked(object sender, RoutedEventArgs e)
        {
            f = fahrrad;
            UpdateDisplay(f);
            
        }
        private void Flugzeug_Checked(object sender, RoutedEventArgs e)
        {
            f = flugzeug;
            UpdateDisplay(f);
        }
        private void KFZ_Checked(object sender, RoutedEventArgs e)
        {
            f = pkw;
            UpdateDisplay(f);
        }
        private void Infos_Click(object sender, RoutedEventArgs e)
        {

          
            UpdateDisplay(f);
        }
    
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            rdoRunning.IsChecked = true;
            currentSpeed = 0;
            lblSpeed.Content = currentSpeed;
            btnChangeSpeed.IsEnabled = true;
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            rdoStopped.IsChecked = true;
            currentSpeed = 0;
            lblSpeed.Content = currentSpeed;
            btnChangeSpeed.IsEnabled = false;
        }

        private void ChangeSpeed_Click(object sender, RoutedEventArgs e)
        {
            if(rdoBoot.IsChecked == true)
            {
                ((Boot)f).Speed = Convert.ToDouble(txtNewSpeed.Text) + ((Boot)f).Speed;
                lblSpeed.Content = ((Boot)f).Speed;
            }
            else if(rdoFahrrad.IsChecked == true)
            {
                ((Fahrrad)f).Speed = Convert.ToDouble(txtNewSpeed.Text) + ((Fahrrad)f).Speed;
                lblSpeed.Content = ((Fahrrad)f).Speed;
            }
            else if (rdoKFZ.IsChecked == true)
            {
                ((PKWmitMotor)f).Speed = Convert.ToDouble(txtNewSpeed.Text) + ((PKWmitMotor)f).Speed;
                lblSpeed.Content = ((PKWmitMotor)f).Speed;
            }
            else if (rdoFlugzeug.IsChecked == true)
            {
                ((Flugzeug)f).Speed = Convert.ToDouble(txtNewSpeed.Text) + ((Flugzeug)f).Speed;
                lblSpeed.Content = ((Flugzeug)f).Speed;
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            currentSpeed = 0;
            rdoBoot.IsChecked = false;
            rdoFahrrad.IsChecked = false;
            rdoFlugzeug.IsChecked = false;
            rdoKFZ.IsChecked = false;
            rdoRunning.IsChecked = false;
            rdoStopped.IsChecked = false;
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = true;
            lblSpeed.Content = "";
            lblInfo.Content = "";
            txtNewSpeed.Text = "";
        }
    }
}


