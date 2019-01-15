using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PruebaClientes.Models
{
    public class Clientes
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
    }

    public class EmptyDBContext: DbContext {
        public EmptyDBContext() { }
        public DbSet<Clientes> Clientes { get; set; }
    }
}