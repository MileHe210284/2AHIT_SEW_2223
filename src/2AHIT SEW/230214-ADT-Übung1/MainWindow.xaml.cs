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

namespace _230214_ADT_Übung1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack<string> stack = new Stack<string>();

     int size;

        public MainWindow()
        {
            InitializeComponent();
        }
        


        private void Push_Click(object sender, RoutedEventArgs e)
        {
           
            stack.Push(txtIn.Text);
            lboStackitems.Items.Add(txtIn.Text);
        }

        private void Pop_Click(object sender, RoutedEventArgs e)
        {
            
            stack.Pop();
            lboStackitems.Items.RemoveAt(0);
            lblOut.Content = txtIn.Text;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            
            lboStackitems.Items.Clear();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void Peek_Click(object sender, RoutedEventArgs e)
        {
            lblOut.Content = stack.Peek();
        }
    }
}
