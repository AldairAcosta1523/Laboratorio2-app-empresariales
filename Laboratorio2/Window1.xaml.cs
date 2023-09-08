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

namespace Laboratorio2
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }
        private void Salidas_Click(object sender, RoutedEventArgs e)
        {
            Window2 salida = new Window2();
            salida.Show();
        }

        private void Camiones_Click(object sender, RoutedEventArgs e)
        {
            Window3 camion = new Window3();
            camion.Show();
        }

        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            Window4 conductor = new Window4();
            conductor.Show();
        }
        private void Reportes_Click(object sender, RoutedEventArgs e)
        {
            Window5 conductor = new Window5();
            conductor.Show();
        }
    } 

}
