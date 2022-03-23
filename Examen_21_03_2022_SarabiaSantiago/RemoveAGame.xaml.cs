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
using System.Windows.Shapes;

namespace Examen_21_03_2022_SarabiaSantiago
{
    /// <summary>
    /// Lógica de interacción para RemoveAGame.xaml
    /// </summary>
    public partial class RemoveAGame : Window
    {
        ParkManager parkManager;

        public RemoveAGame(ParkManager park)
        {
            InitializeComponent();
            this.parkManager = park;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtError.Visibility = Visibility.Hidden;
            if (parkBox.Text != "")
            {
                if (parkManager.getPark(parkBox.Text).ParkName != "invalid")
                {
                    if (parkManager.getPark(parkBox.Text).ParkGames.Count > 0)
                    {
                        Game gm = parkManager.removeParkGame(parkBox.Text);
                        txtError.Text = "Game " + gm.GameName + " has been eliminated";
                    } else
                    {
                        txtError.Text = "This park does not contain any games";
                    }
                } else
                {
                    txtError.Text = "Park does not exist";
                }
            } else
            {
                txtError.Text = "Invalid park name";
            }
            txtError.Visibility = Visibility.Visible;
        }
    }
}
