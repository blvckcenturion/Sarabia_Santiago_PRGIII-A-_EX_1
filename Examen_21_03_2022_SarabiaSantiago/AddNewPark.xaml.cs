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
    /// Lógica de interacción para AddNewPark.xaml
    /// </summary>
    public partial class AddNewPark : Window
    {

        public ParkManager pk;
        public AddNewPark(ParkManager pk)
        {
            this.pk = pk;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtError.Visibility = Visibility.Hidden;
            if (parkBox.Text != "")
            {
                if (!pk.addPark(parkBox.Text))
                {
                    txtError.Visibility = Visibility.Visible;
                    txtError.Text = "Park "+ parkBox.Text +" already exists";
                } else
                {
                    this.Close();
                };
            } else
            {
                txtError.Visibility = Visibility.Visible;
                txtError.Text = "Invalid park name";
            }
        }
    }
}
