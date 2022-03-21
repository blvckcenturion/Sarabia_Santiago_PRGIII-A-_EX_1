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

        AddNewPark addNewPark;
        AddNewGame addNewGame;
        

        public MainWindow()
        {
            InitializeComponent();
            parkManager = new ParkManager();
            addNewPark = new AddNewPark(parkManager);
            addNewGame = new AddNewGame(parkManager);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            addNewPark.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
