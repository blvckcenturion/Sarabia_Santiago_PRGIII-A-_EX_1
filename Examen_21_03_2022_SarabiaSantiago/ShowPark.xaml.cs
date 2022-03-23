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
    /// Lógica de interacción para ShowPark.xaml
    /// </summary>
    public partial class ShowPark : Window
    {
        ParkManager parkManager;
        public ShowPark(ParkManager park)
        {
            InitializeComponent();
            this.parkManager = park;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Park pk in parkManager.getParks())
            {
                lstShow.Items.Add("Parque: " + pk.ParkName);
                if (pk.ParkGames.Count > 0)
                {
                    lstShow.Items.Add("Juegos:");
                }
                else
                {
                    lstShow.Items.Add("Ese parque no tiene juegos.");
                }
                foreach (Game gm in pk.ParkGames)
                {
                    lstShow.Items.Add("Nombre del juego: " + gm.GameName);
                    lstShow.Items.Add("Capacidad Maxima:" + gm.MaxCapacity);
                }
                lstShow.Items.Add("---------------------------------------------------------------------------------");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lstShow.Items.Clear();
            int qty;
            bool isValid = int.TryParse(txtInput.Text, out qty);
            List<Game> gamesFiltered = new List<Game>();
            lstShow.Items.Add("Juegos con capacidad mayor a: " + qty);
            if (isValid)
            {
                foreach (Park pk in parkManager.getParks())
                {
                    foreach (Game gm in pk.ParkGames)
                    {
                        if (gm.MaxCapacity >= qty) lstShow.Items.Add("Game:" + gm.GameName + " | Max Capacity: " + gm.MaxCapacity);
                    }
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lstShow.Items.Clear();
            if (txtInput.Text != "")
            {
                foreach (Park pk in parkManager.getParks())
                {
                    foreach (Game gm in pk.ParkGames)
                    {
                        if (gm.GameName.ToLower() == txtInput.Text.ToLower())
                        {
                            lstShow.Items.Add("El juego " + txtInput.Text + " se encuentra en el Parque :" + pk.ParkName);
                        }

                    }
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            lstShow.Items.Clear();
            if (txtInput.Text != "")
            {
                foreach(Park pk in parkManager.getParks())
                {
                    if (pk.ParkName.ToLower() == txtInput.Text.ToLower())
                    {
                        lstShow.Items.Add("Park: " + pk.ParkName);
                        foreach (Game gm in pk.ParkGames)
                        {
                            lstShow.Items.Add("Game: " + gm.GameName + " | Max Capacity: " + gm.MaxCapacity);
                        }
                    }
                }
            }
        }
    }
}
