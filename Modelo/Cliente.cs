using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Proyecto_GYM.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Correo { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Dia { get; set; }

        public string Mes { get; set; }

        public string Anio { get; set; }

        public string Altura { get; set; }

        public string Peso { get; set; }

        public string Edad { get; set; }

        public string Membresia { get; set; }

       
    }
}
