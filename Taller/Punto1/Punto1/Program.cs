using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1

{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string nombre = string.Empty;
                int clave = 0;

                try
                {

                    Console.Clear();
                    Console.WriteLine("Registro de Usuario");
                    Console.Write("Ingrese su nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese su clave: ");
                    clave = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("\nBienvenido, " + nombre);
                    Console.Write("Ingrese el monto a retirar (máximo 200.000): ");
                    int monto = int.Parse(Console.ReadLine());

                    if (monto > 200000)
                    {
                        Console.WriteLine("El monto máximo permitido es 200.000 pesos.");
                        break;
                    }
                    monto = Ajuste(monto);
                    CantBilletes(monto);
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    Console.WriteLine("Presione una tecla para volver al inicio...");
                    Console.ReadKey();
                }
            }
        }

        static int Ajuste(int monto)
        {
            int residuo = monto % 1000;
            if (residuo >= 500)
            {
                monto += (1000 - residuo);
            }
            else
            {
                monto -= residuo;
            }
            return monto;
        }

        static void CantBilletes(int monto)
        {
            int[] valor = { 10000, 5000, 2000, 1000 };
            int[] cantidad = new int[valor.Length];

            for (int i = 0; i < valor.Length; i++)
            {
                cantidad[i] = monto / valor[i];
                monto %= valor[i];
            }

            Console.WriteLine("Cantidad de billetes:");
            for (int i = 0; i < valor.Length; i++)
            {
                if (cantidad[i] > 0)
                {
                    Console.WriteLine($"{cantidad[i]} billetes de: " + $"{valor[i]}");
                }
            }
        }
    }
}
