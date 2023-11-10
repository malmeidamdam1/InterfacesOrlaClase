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
    /// Lógica de interacción para Puesto.xaml
    /// </summary>
    public partial class Puesto : Window
    {
        public Puesto()
        {
            InitializeComponent();
        }

       
        public static DependencyProperty NombreProperty = DependencyProperty.Register("Apellidos", typeof(string), typeof(Puesto),
            new PropertyMetadata(string.Empty));

        public string Nombre
        {
            get { return (string)GetValue(NombreProperty); }
            set { SetValue(NombreProperty, value); }
        }

        //Propiedad2
        public static DependencyProperty ApellidosProperty = DependencyProperty.Register("Nombre", typeof(string), typeof(Puesto),
            new PropertyMetadata(string.Empty));

        public string Apellidos
        {
            get { return (string)GetValue(ApellidosProperty); }
            set { SetValue(ApellidosProperty, value); }
        }

        //Propiedad3
        public static DependencyProperty EmailProperty = DependencyProperty.Register("Email", typeof(string), typeof(Puesto),
            new PropertyMetadata(string.Empty));

        public string Email
        {
            get { return (string)GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }

        //Propiedad4
        public static DependencyProperty FotoProperty = DependencyProperty.Register("Foto", typeof(string), typeof(Puesto),
             new PropertyMetadata(string.Empty));

        public string Foto
        {
            get { return (string)GetValue(FotoProperty); }
            set { SetValue(FotoProperty, value); }
        }

        private void Persona_MouseEnter(object sender, MouseEventArgs e)
        {
            LabelPuesto.Text = Nombre + " " + Apellidos;
        }

        private void Persona_MouseLeave(object sender, MouseEventArgs e)
        {
            LabelPuesto.Text = "";

        }

        private void Persona_Click(object sender, RoutedEventArgs e)
        {
            LabelPuesto.Text = Email;
        }

        private void Persona_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Profile win2 = new Profile(Nombre, Apellidos, Email, Foto);
            win2.Show();
        }
    }
}
