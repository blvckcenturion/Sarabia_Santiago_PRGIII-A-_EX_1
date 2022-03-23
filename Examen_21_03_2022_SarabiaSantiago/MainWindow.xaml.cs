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

namespace Examen_21_03_2022_SarabiaSantiago
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ParkManager parkManager;

        public MainWindow()
        {
            InitializeComponent();
            parkManager = new ParkManager();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new AddNewPark(parkManager).Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new AddNewGame(parkManager).Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new RemoveAGame(parkManager).Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            new ShowPark(parkManager).Show();
        }
    }
}
