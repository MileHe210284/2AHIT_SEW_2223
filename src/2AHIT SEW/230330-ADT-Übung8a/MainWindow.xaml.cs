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

namespace _230330_ADT_Übung8a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Que<string> item = new Que<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Enqueue_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                item.Enqueue(txtIn.Text);
                lboItem.Items.Insert(0, item.Peek());
            }
            catch (StackFullException exp)
            {
                MessageBox.Show(exp.Message, "stack full; can't add items");
            }


        }

        private void Dequeue_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                item.Dequeue();
                lboItem.Items.RemoveAt(0);
            }
            catch (StackEmptyException exp)
            {
                MessageBox.Show(exp.Message, "Stack empty; cannot dequeue");
            }


        }

        private void btnPeek_Click(object sender, RoutedEventArgs e)
        {
            string input = txtIn.Text;
            try
            {

                lblOut.Content = item.Peek();
            }
            catch (StackEmptyException exp)
            {
                MessageBox.Show(exp.Message, "Stack empty; nothing to see here");
            }
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lboItem.Items.Clear();
                lblCount.Content = Convert.ToString(item.pointer);
            }
            catch (StackEmptyException exp)
            {
                MessageBox.Show(exp.Message, "Stack empty, nothing to clear");
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void MoveFirst_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MoveNext_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MoveLast_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
