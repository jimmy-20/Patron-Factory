using Patron_Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Factory.DataBase
{
    public class ConexionSQL : IAcciones
    {
        public void Conexion()
        {
            Console.WriteLine("Conexion abierta a SQL");
        }

        public void Desconectar()
        {
            Console.WriteLine("Se desconecto de SQL");
        }
    }
}
