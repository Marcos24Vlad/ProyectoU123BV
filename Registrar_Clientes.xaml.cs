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
using Proyecto_GYM.Context;
using Proyecto_GYM.Modelo;

namespace Proyecto_GYM
{
    /// <summary>
    /// Lógica de interacción para Registrar_Clientes.xaml
    /// </summary>
    public partial class Registrar_Clientes : Window
    {
        public Registrar_Clientes()
        {
            InitializeComponent();
        }

        private void cmbDia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbDia.Items.Add("1");
            cmbDia.Items.Add("2");
            cmbDia.Items.Add("3");
            cmbDia.Items.Add("4");
            cmbDia.Items.Add("5");
            cmbDia.Items.Add("6");
            cmbDia.Items.Add("7");
            cmbDia.Items.Add("8");
            cmbDia.Items.Add("9");
            cmbDia.Items.Add("10");
            cmbDia.Items.Add("11");
            cmbDia.Items.Add("12");
            cmbDia.Items.Add("13");
            cmbDia.Items.Add("14");
            cmbDia.Items.Add("15");
            cmbDia.Items.Add("16");
            cmbDia.Items.Add("17");
            cmbDia.Items.Add("18");
            cmbDia.Items.Add("19");
            cmbDia.Items.Add("20");
            cmbDia.Items.Add("21");
            cmbDia.Items.Add("22");
            cmbDia.Items.Add("23");
            cmbDia.Items.Add("24");
            cmbDia.Items.Add("25");
            cmbDia.Items.Add("26");
            cmbDia.Items.Add("27");
            cmbDia.Items.Add("28");
            cmbDia.Items.Add("29");
            cmbDia.Items.Add("30");
            cmbDia.Items.Add("31");
        }

        private void cmbMes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbMes.Items.Add("Enero");
            cmbMes.Items.Add("Febrero");
            cmbMes.Items.Add("Marzo");
            cmbMes.Items.Add("Abril");
            cmbMes.Items.Add("Mayo");
            cmbMes.Items.Add("Junio");
            cmbMes.Items.Add("Julio");
            cmbMes.Items.Add("Agosto");
            cmbMes.Items.Add("Septiembre");
            cmbMes.Items.Add("Octubre");
            cmbMes.Items.Add("Noviembre");
            cmbMes.Items.Add("Diciembre");
        }

        private void cmbAño_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbAño.Items.Add("1990");
            cmbAño.Items.Add("1991");
            cmbAño.Items.Add("1992");
            cmbAño.Items.Add("1993");
            cmbAño.Items.Add("1994");
            cmbAño.Items.Add("1995");
            cmbAño.Items.Add("1996");
            cmbAño.Items.Add("1997");
            cmbAño.Items.Add("1998");
            cmbAño.Items.Add("1999");
            cmbAño.Items.Add("2000");
            cmbAño.Items.Add("2001");
            cmbAño.Items.Add("2002");
            cmbAño.Items.Add("2003");
            cmbAño.Items.Add("2004");
            cmbAño.Items.Add("2005");
            cmbAño.Items.Add("2006");
            cmbAño.Items.Add("2007");
            cmbAño.Items.Add("2008");
            cmbAño.Items.Add("2009");
            cmbAño.Items.Add("2010");
            cmbAño.Items.Add("2011");
            cmbAño.Items.Add("2012");
            cmbAño.Items.Add("2013");
            cmbAño.Items.Add("2014");
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente();
            using (var _context = new AplicationdbContext())
            {
                cliente.Nombre = txtNombre.Text;
                txtNombre.Clear();
                cliente.Apellido = txtApellido.Text;
                txtApellido.Clear();
                cliente.Correo = txtCorreo.Text;
                txtCorreo.Clear();
                cliente.Telefono = txtTelefono.Text;
                txtTelefono.Clear();
                cliente.Direccion = txtDireccion.Text;
                txtDireccion.Clear();
                cliente.Dia = cmbDia.Text;
                cliente.Mes = cmbMes.Text;
                cliente.Anio = cmbAño.Text;
                cliente.Altura = txtAltura.Text;
                txtAltura.Clear();
                cliente.Peso = txtPeso.Text;
                txtPeso.Clear();
                cliente.Edad = txtEdad.Text;
                txtEdad.Clear();
                cliente.Membresia = cmbMembresia.Text;

                _context.Add(cliente);
                _context.SaveChanges();

                MessageBox.Show("Se a registrado correctamente un nuevo Cliente ");
            }







           
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();

            this.Hide();
        }

        private void cmbMembresia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbMembresia.Items.Add("Basico");
            cmbMembresia.Items.Add("Estandar");
            cmbMembresia.Items.Add("Premium");
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
            Registrar_Empleados registrar = new Registrar_Empleados();
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
