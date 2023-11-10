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

namespace Aplicacion_Orla_de_clase
{
    /// <summary>
    /// Lógica de interacción para OrlaMano.xaml
    /// </summary>
    public partial class OrlaMano : Window
    {
        public OrlaMano()
        {
            InitializeComponent();
        }
        private void MouseEnter11(object sender, MouseEventArgs e)
        {
            LabelPuesto11.Text = "Aitor puesto 1.1";
        }

        private void MouseLeave11(object sender, MouseEventArgs e)
        {
            LabelPuesto11.Text = " ";
        }

        private void MouseClick11(object sender, RoutedEventArgs e)
        {
            LabelPuesto11.Text = "email_aitorC@educacion.navarra.es";
        }

        private void MouseClick12(object sender, RoutedEventArgs e)
        {
            LabelPuesto11.Text = "email_aitorC@educacion.navarra.es";
        }

        private void Peronsa11_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Profile win2 = new Profile("Aitor", "Cuadrado", "aitor@gmail.com", "src/Aitor.png");
            win2.Show();
        }
    }
}
