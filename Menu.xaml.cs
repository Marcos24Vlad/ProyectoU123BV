using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Proyecto_GYM
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnRegistrarempleados_Click(object sender, RoutedEventArgs e)
        {
            Registrar_Empleados registrar = new Registrar_Empleados();
            registrar.Show();


            this.Hide();
        }

        private void BtnListaempleados_Click(object sender, RoutedEventArgs e)
        {
            Lista_Empleados lista = new Lista_Empleados();
            lista.Show();

            this.Hide();
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            Registrar_Clientes registrar = new Registrar_Clientes();
            registrar.Show();

            this.Hide();
        }

        private void btnListaclientes_Click(object sender, RoutedEventArgs e)
        {
            Lista_Clientes lista = new Lista_Clientes();
            lista.Show();


            this.Hide();
        }
    }
}
