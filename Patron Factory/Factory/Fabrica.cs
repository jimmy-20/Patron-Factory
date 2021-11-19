using Patron_Factory.DataBase;
using Patron_Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Factory.Factory
{
    public class Fabrica
    {
        public Fabrica() { }
        public static IAcciones Connection(string ServerName)
        {
            switch (ServerName)
            {
                case "SQL":
                    return new ConexionSQL();
                    break;
                case "Oracle":
                    return new ConexionOracle();
                    break;
            }

            return new ConexionVacia();
        }
    }
}
