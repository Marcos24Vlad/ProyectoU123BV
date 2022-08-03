using Microsoft.EntityFrameworkCore;
using Proyecto_GYM.Context;
using Proyecto_GYM.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Lógica de interacción para Lista_Clientes.xaml
    /// </summary>
    public partial class Lista_Clientes : Window
    {
        public List<Membresias> Membreias { get; set; }
        public Lista_Clientes()

        {
            InitializeComponent();
            GetClientes();
        }


        private void GetClientes()
        {


            using (var _context = new AplicationdbContext())
            {
                UserTable.ItemsSource = _context.Clientes.ToList();

            }



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();

            this.Hide();
        }

        private void SelectItem(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente = (sender as FrameworkElement).DataContext as Cliente;

                txtId.Text = cliente.Id.ToString();
                txtNombre.Text = cliente.Nombre.ToString();
                txtApellido.Text = cliente.Apellido.ToString();
                txtTelefono.Text = cliente.Telefono.ToString();
                txtEdad.Text = cliente.Edad.ToString();
                cmbMembresia.Text = cliente.Membresia.ToString();


            }
            catch (Exception ex)
            {

                throw new Exception("Error interno: " + ex.Message);
            }

        }

        private void cmbMembresia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbMembresia.Items.Add("Basico");
            cmbMembresia.Items.Add("Estandar");
            cmbMembresia.Items.Add("Premium");
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Cliente clienteUpdate = new Cliente();

            clienteUpdate.Id = int.Parse(txtId.Text);

            using (var _context = new AplicationdbContext())
            {
                clienteUpdate = _context.Clientes.Find(clienteUpdate.Id);
                clienteUpdate.Nombre = txtNombre.Text;
                clienteUpdate.Apellido = txtApellido.Text;
                clienteUpdate.Telefono = txtTelefono.Text;
                clienteUpdate.Edad = txtEdad.Text;
                clienteUpdate.Membresia = cmbMembresia.Text;




                _context.Entry(clienteUpdate).State = EntityState.Modified;
                _context.SaveChanges();

                GetCleintes();

                MessageBox.Show("Se a guardado cambios correctamente");
            }
        }

        private void GetCleintes()
        {
            
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
            Lista_Clientes clientes = new Lista_Clientes();
            clientes.Show();

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

