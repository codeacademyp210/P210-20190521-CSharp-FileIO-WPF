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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person p = new Person()
        {
            Name = "Elnur",
            Age = 24
        };

        List<string> list = new List<string>();
        

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = p;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = p.Name + " is " + p.Age;
            list.Add(message);

            foreach (var item in list)
            {
                MessageBox.Show(item);
            }
            MessageBox.Show(p.Name);

        }

        private void TxtTest_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


}
