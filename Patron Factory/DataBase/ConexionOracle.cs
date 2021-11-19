using Patron_Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Factory.DataBase
{
    public class ConexionOracle : IAcciones
    {
        public void Conexion()
        {
            Console.WriteLine("Conexion establecia a Oracle");
        }

        public void Desconectar()
        {
            Console.WriteLine("Saliendo de Oracle");
        }
    }
}
