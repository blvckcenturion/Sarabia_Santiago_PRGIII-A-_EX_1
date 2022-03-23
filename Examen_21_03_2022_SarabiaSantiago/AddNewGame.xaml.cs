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
    /// Lógica de interacción para AddNewGame.xaml
    /// </summary>
    public partial class AddNewGame : Window
    {
        public ParkManager parkManager;
        public AddNewGame(ParkManager pk)
        {
            this.parkManager = pk;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtError.Visibility = Visibility.Hidden;
            int qty = 0;
            bool isValidQty = int.TryParse(qtyBox.Text, out qty);
            if(nameBox.Text != "" && qtyBox.Text != "" && parkBox.Text != "" && isValidQty)
            {

                if(parkManager.getPark(parkBox.Text).ParkName != "invalid")
                {
                    bool valid = parkManager.addParkGame(nameBox.Text, int.Parse(qtyBox.Text), parkBox.Text);
                    if(!valid)
                    {
                        txtError.Visibility = Visibility.Visible;
                        txtError.Text = "Game already exists in that park";
                    } else
                    {
                        this.Close();
                    }
                } else
                {
                    txtError.Visibility = Visibility.Visible;
                    txtError.Text = "Invalid park name";
                }
            } else
            {
                txtError.Visibility = Visibility.Visible;
                txtError.Text = "Error, the inserted data is not valid";
            }
        }
    }
}
