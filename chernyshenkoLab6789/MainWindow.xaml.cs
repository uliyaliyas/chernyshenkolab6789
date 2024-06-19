using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace chernyshenkoLab6789
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> listLab1;
        private Queue<int> queue;
        private List<int> listLab3;
        public MainWindow()
        {
            InitializeComponent();
            listLab1 = new List<int>();
            queue = new Queue<int>();
            listLab3 = new List<int>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listLab1.Add(int.Parse(tbElement.Text));
            lbList.ItemsSource = null;
            lbList.ItemsSource = listLab1;
            tbElement.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int index = lbList.SelectedIndex;
            listLab1.RemoveAt(index);
            lbList.ItemsSource = null;
            lbList.ItemsSource = listLab1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int secondPositiveIndex = -1;
            int positiveCount = 0;
            foreach (int i in listLab1)
            {
                    positiveCount++;
                    if (positiveCount == 2)
                    {
                        secondPositiveIndex = i;                     
                    }
                Result.Text = "Индекс второго положительного элемента:" + positiveCount.ToString();
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            queue.Enqueue(int.Parse(tbElementQueue.Text));
            lbQueue.ItemsSource = null;
            lbQueue.ItemsSource = queue;
            tbElementQueue.Text = "";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {    
            double average=0;
            int count = 0;
            foreach (int n in queue)
            {
                if (n % 2 == 0)
                {
                    count++;
                    average += n;
                }
            }
            if (count > 0)
            {
                average /= count;
            }
            double result = average;
            tbResultQueue.Text = result.ToString();
            lbQueue.ItemsSource = null;
            lbQueue.ItemsSource = queue;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            listLab3.Add(int.Parse(tbElementAdd.Text));
            lbList3.Items.Clear();
            foreach (int item in listLab3)
            {
                lbList3.Items.Add(item);
            }
            tbElementAdd.Text = "";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int i = 0;
            foreach (var index in listLab3)
            {
                if(index<0) listLab3.Insert(i, 10);
            }
            lbList3.Items.Clear();
            foreach (int item in listLab3)
            {
                lbList3.Items.Add(item);
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            listLab3.Clear();
            lbList3.Items.Clear();
        }
    }
}