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

namespace WpfUi
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();

            people.Add(new Person { FirstName = "Mike", LastName = "Müller" });
            people.Add(new Person { FirstName = "Jörg", LastName = "Jörgensen" });
            people.Add(new Person { FirstName = "Otto", LastName = "Matschkovski" });
            people.Add(new Person { FirstName = "Paul", LastName = "Puma" });

            comboBox.ItemsSource = people;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {firstName.Text} ");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
