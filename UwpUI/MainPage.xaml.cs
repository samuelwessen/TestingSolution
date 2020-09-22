using SharedUwpLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UwpUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Employees employees = new Employees();


        public MainPage()
        {
            this.InitializeComponent();

            
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                employees.Add(new Employee(tbFirstName.Text, tbLastName.Text, cmbDepartment.SelectedItem.ToString()));
            }
            catch { }
            finally
            {
                tbFirstName.Text = "";
                tbLastName.Text = "";
                cmbDepartment.SelectedIndex = -1;
            }
        }

        private void btnDeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var button = sender as Button;
                var employee = (Employee)button.DataContext;

                employees.RemoveAt(employees.IndexOf(employee));
            }
            catch { }
        }
    }
}
