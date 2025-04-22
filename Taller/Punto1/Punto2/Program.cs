using Punto2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            List<Usuario> usuarios = new List<Usuario>();
            do
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("1. Ingresar usuario");
                    Console.WriteLine("2. Estadisticas de los usuarios");
                    Console.WriteLine("3. Salir");

                    try
                    {
                        option = Int32.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                        Console.WriteLine("Ingrese una tecla para regresar");
                        Console.ReadKey();
                    }

                }

                switch (option)
                {
                    case 1:


                        while (true)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Ingrese el numero de cuenta del usuario");
                                long id = Int64.Parse(Console.ReadLine());

                                if (usuarios.Exists(x => x.Id == id))
                                {
                                    Console.WriteLine("El usuario ya existe");
                                    Console.WriteLine("Ingrese una tecla para regresar");
                                    Console.ReadKey();
                                    continue;

                                }

                                Console.WriteLine("Ingrese el saldo del usuario");
                                double saldo = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Ingrese el nombre del usuario");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese el genero del usuario (M/F)");
                                string genero = Console.ReadLine().ToUpper().Trim();

                                if (genero == "M" || genero == "F")
                                {
                                    Usuario usuario = new Usuario(id, saldo, nombre, genero);
                                    usuarios.Add(usuario);
                                    usuario = null;
                                    Console.WriteLine("Usuario ingresado exitosamente");
                                    Console.WriteLine("Ingrese una tecla para regresar");
                                    Console.ReadKey();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Genero no valido");
                                    Console.WriteLine("Ingrese una tecla para regresar");
                                    Console.ReadKey();
                                }

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Error: " + e.Message);
                                Console.WriteLine("Ingrese una tecla para regresar");
                                Console.ReadKey();

                            }
                        }
                        break;

                    case 2:
                        if (usuarios.Count == 0)
                        {
                            Console.WriteLine("No hay usuarios ingresados");
                            Console.WriteLine("Ingrese una tecla para regresar");
                            Console.ReadKey();
                            break;

                        }

                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Estadisticas de los usuarios");
                            Console.WriteLine("Cantidad de usuarios: " + usuarios.Count);
                            Console.WriteLine("Saldo promedio de los usuarios: " + usuarios.Average(x => x.Saldo));
                            Console.WriteLine("Usuarios con saldo positivo: " + usuarios.Count(x => x.Saldo >= 0));
                            Console.WriteLine("Usuarios con saldo negativo: " + usuarios.Count(x => x.Saldo < 0));

                            double promM = usuarios.Where(x => x.Genero == "M").Average(x => x.Saldo);
                            double promF = usuarios.Where(x => x.Genero == "F").Average(x => x.Saldo);
                            var max = usuarios.Max(x => x.Saldo);
                            var min = usuarios.Min(x => x.Saldo);

                            Console.WriteLine("===============================================\n" +
                                "Usuario con mayor saldo: " + usuarios.Find(x => x.Saldo == max).Nombre
                                 + "\nNumero de cuenta: " + usuarios.Find(x => x.Saldo == max).Id +
                                 "\nSaldo: " + usuarios.Find(x => x.Saldo == max).Saldo +
                                 "\n===============================================\n");

                            Console.WriteLine("===============================================\n" +
                                "Usuario con menor saldo: " + usuarios.Find(x => x.Saldo == min).Nombre
                                 + "\nNumero de cuenta: " + usuarios.Find(x => x.Saldo == min).Id +
                                 "\nSaldo: " + usuarios.Find(x => x.Saldo == min).Saldo +
                                 "===============================================\n");

                            Console.WriteLine("Saldo promedio de los hombres: " + promM
                                + "\nSaldo Promedio de las mujeres: " + promF);
                            Console.WriteLine("Ingrese una tecla para regresar");
                            Console.ReadKey();
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }

                        break;

                    default:
                        Console.WriteLine("Opcion no valida, regresando al inicio");
                        Console.WriteLine("Ingrese una tecla para regresar");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        Thread.Sleep(4000);
                        break;
                }
            } while (option != 3);
        }
    }
}
