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

namespace _230307_Enqueue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Q<string> item = new Q<string>();

        public MainWindow() => InitializeComponent();



        private void Dequeue_Click(object sender, RoutedEventArgs e)
        {
            item.Deque();
            lboItem.Items.RemoveAt(0);
            lblOut.Content = txtIn.Text;
        }

        private void Enqueue_Click(object sender, RoutedEventArgs e)
        {
            string input = txtIn.Text;
            try
            {
                item.Enque(input);
                lboItem.Items.Insert(0, item.Peek());
                lblCount.Content = Convert.ToString(item.count);
            }
            catch (QueueFullException exp)
            {
                MessageBox.Show(exp.Message, "Exception");
            }
            catch (Exception exp)
            {
                txtIn.Text = exp.Message;
            }

        }

        private void Peek_Click(object sender, RoutedEventArgs e)
        {
            lblOut.Content = item.Peek();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }


    }
}
