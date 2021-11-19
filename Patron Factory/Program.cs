using Patron_Factory.Factory;
using Patron_Factory.Interface;
using System;

namespace Patron_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IAcciones conexion = Fabrica.Connection("SQL");

            conexion.Conexion();

            IAcciones conexion2 = Fabrica.Connection("MySql");
            conexion2.Conexion();

            conexion.Desconectar();
        }
    }
}