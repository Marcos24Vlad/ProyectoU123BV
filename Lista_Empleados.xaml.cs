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
    /// Lógica de interacción para Lista_Empleados.xaml
    /// </summary>
    public partial class Lista_Empleados : Window
    {
        public List<Roles> Roles { get; set; }                   
        public Lista_Empleados()

        {
            InitializeComponent();
            GetEmpleados();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();

            this.Hide();
            }

            private void GetEmpleados()
        {


            using (var _context = new AplicationdbContext())
            {
                UserTable.ItemsSource = _context.Empleados.ToList();

            }

          
            }

        

       

        private void cmbMembresia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbPuesto.Items.Add("Administrador");
            cmbPuesto.Items.Add("Instrcutor");
            cmbPuesto.Items.Add("Limepieza");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                Empleado empleadoDelete = new Empleado();
                empleadoDelete = (sender as FrameworkElement).DataContext as Empleado;



                using (var _context = new AplicationdbContext())
                {
                    empleadoDelete = _context.Empleados.Find(empleadoDelete.Id);
                    _context.Entry(empleadoDelete).State = EntityState.Deleted;
                    //_context.Remove(userDelete);
                    _context.SaveChanges();
                    GetEmpleados();

                    MessageBox.Show("Se a borrado correctamente");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error interno:" + ex.Message);
            }
        }

          private void SelectItem(object sender, RoutedEventArgs e)
        {
            try
            {
                Empleado empleado = new Empleado();
                empleado = (sender as FrameworkElement).DataContext as Empleado;

                txtId.Text = empleado.Id.ToString();
                txtNombre.Text = empleado.Nombre.ToString();
                txtApellido.Text = empleado.Apellido.ToString();
                cmbPuesto.Text = empleado.Puesto.ToString();
               


            }
            catch (Exception ex)
            {

                throw new Exception("Error interno: " + ex.Message);
            }

        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            Empleado empleadoUpdate = new Empleado();

            empleadoUpdate.Id = int.Parse(txtId.Text);

            using (var _context = new AplicationdbContext())
            {
                empleadoUpdate = _context.Empleados.Find(empleadoUpdate.Id);
                empleadoUpdate.Nombre = txtNombre.Text;
                empleadoUpdate.Apellido = txtApellido.Text;               
                empleadoUpdate.Puesto = cmbPuesto.Text;




                _context.Entry(empleadoUpdate).State = EntityState.Modified;
                _context.SaveChanges();

                GetEmpleados();

                MessageBox.Show("Se a guardado cambios correctamente");
            }
        }

        private void cmbPuesto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbPuesto.Items.Add("Administrador");
            cmbPuesto.Items.Add("Instructor");
            cmbPuesto.Items.Add("Limpieza");
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
            Registrar_Clientes regitrar = new Registrar_Clientes();
            regitrar.Show();


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
