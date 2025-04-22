using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    public class GeneralIO
    {
        public static void imp(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public static string lea(string mensaje)
        {
            imp(mensaje);
            return Console.ReadLine();
        }
    }
}
