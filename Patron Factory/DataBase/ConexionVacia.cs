using Patron_Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Patron_Factory.DataBase
{
    public class ConexionVacia : IAcciones
    {
        public void Conexion()
        {
            Console.WriteLine("NONE");
        }
        public void Desconectar()
        {
            Console.WriteLine("NONE");
        }
    }
}
