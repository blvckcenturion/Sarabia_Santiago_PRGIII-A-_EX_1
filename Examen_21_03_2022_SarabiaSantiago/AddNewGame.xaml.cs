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
            if(nameBox.Text != "" && qtyBox.Text != "" && parkBox.Text != "")
            {
                parkManager.addParkGame(nameBox.Text, int.Parse(qtyBox.Text), parkBox.Text);
            }
        }
    }
}
