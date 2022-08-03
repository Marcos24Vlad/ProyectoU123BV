using Proyecto_GYM.Context;
using Proyecto_GYM.Modelo;
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
    /// Lógica de interacción para Registrar_Empleados.xaml
    /// </summary>
    public partial class Registrar_Empleados : Window
    {
        public Registrar_Empleados()
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
            cmbMes.Items.Add("Novimebre");
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

        private void cmbPuesto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbPuesto.Items.Add("Administrador");
            cmbPuesto.Items.Add("Intructor");
            cmbPuesto.Items.Add("Limpieza");
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Empleado empleado = new Empleado();
            using (var _context = new AplicationdbContext())
            {
                empleado.Nombre = txtNombre.Text;
                txtNombre.Clear();
                empleado.Apellido = txtApellido.Text;
                txtApellido.Clear();
                empleado.Correo = txtCorreo.Text;
                txtCorreo.Clear();
                empleado.Telefono = txtTelefono.Text;
                txtTelefono.Clear();
                empleado.Direccion = txtDireccion.Text;
                txtDireccion.Clear();
                empleado.Dia = cmbDia.Text;
                empleado.Mes = cmbMes.Text;
                empleado.Anio = cmbAño.Text;
                empleado.Puesto = cmbPuesto.Text;


                _context.Add(empleado);
                _context.SaveChanges();

                MessageBox.Show("Se a registrado Empleado Correctamente ");




            }

            Menu menu = new Menu();
            menu.Show();

            this.Hide();
        }

       
        

      
        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();

            this.Hide();
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
            Registrar_Clientes cliente = new Registrar_Clientes();
            cliente.Show();

            this.Hide();
        }

        private void btnListaclientes_Click(object sender, RoutedEventArgs e)
        {
            Lista_Empleados lista = new Lista_Empleados();
            lista.Show();

            this.Hide();
        }
    }
}
