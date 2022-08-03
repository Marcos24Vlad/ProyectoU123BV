
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Proyecto_GYM.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string User { get; set; }
        
        public string Password { get; set; }
    }
}
