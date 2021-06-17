using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDay03
{
    /// <summary>
    /// Interaction logic for BindingObject.xaml
    /// </summary>
    public partial class BindingObject : Window
    {
        List<Employee> employees;
        public BindingObject()
        {
            InitializeComponent();
           employees = new List<Employee>()
           {
               new Employee(){ Id=1,Fname="Hamada",LastName="Hamada2"},
               new Employee(){ Id=2,Fname="Hamada",LastName="Hamada2"}, 
               new Employee(){ Id=3,Fname="Hamada",LastName="Hamada2"},
               new Employee(){ Id=4,Fname="Hamada",LastName="Hamada2"},
               new Employee(){ Id=5,Fname="Hamada",LastName="Hamada2"},
               new Employee(){ Id=6,Fname="Hamada",LastName="Hamada2"},
           }
                ; 


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            combo.ItemsSource = employees;

        }

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            stp.DataContext = combo.SelectedItem;

        }
    }

}
