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

namespace John_Farrelly_S00188044
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Computer> Computers = new List<Computer>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ComputerLbx.ItemsSource = Computers;

            PriceBx.Text = "No Computer Selected";
        }

        private void ComputerLbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Computer.ComputerData selectedPhone = ComputerLbx.SelectedItem as Computer.ComputerData;
            if (Computers != null)
            {
                //adds price
                 //PriceBx.Text = selectedComputers;
            }
            else
            {
                PriceBx.Text = null;
            }
        }
    }
}
