using Microsoft.EntityFrameworkCore;
using Proyecto_GYM.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_GYM.Context
{
    public class AplicationdbContext : DbContext
    {
        
           protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                options.UseMySQL("server = localhost; database= proyecto_gym; user= root; password= ");
            }

            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Empleado> Empleados  { get; set; }
            public DbSet<Cliente> Clientes { get; set; }
    }
    }

