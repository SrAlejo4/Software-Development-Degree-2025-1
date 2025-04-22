using System;
using System.Collections.Generic;

namespace AgendaAmigos
{
    public class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            do
            {
                Console.Write("\t\n - - - - - - - - - MENÚ AGENDA - - - - - - - - - \n" +
                                               "1. Agregar " +
                                               "\n2. Imprimir agenda " +
                                               "\n3. Buscar por código " +
                                               "\n4. Buscar por nombre " +
                                               "\n5. Eliminar" +
                                               "\n6. SALIR PROGRAMA" +
                                               "\n Ingrese la opción: ");
                op = Int32.Parse(Console.ReadLine());

                switch (op) 
                {
                    case 1:
                        VectorAmigos.agregarAmigo();
                        break;
                    case 2:
                        VectorAmigos.imprimirAgenda();
                        break;
                    case 3:
                        string codigo = VectorAmigos.leer("Ingrese el código de la persona: ");
                        VectorAmigos.buscarAmigoCodigo(codigo);
                        break;
                    case 4:
                        string nombre = VectorAmigos.leer("Ingrese el nombre de la persona: ");
                        VectorAmigos.buscarAmigoNombre(nombre);
                        break;
                    case 5:
                        codigo = VectorAmigos.leer("Ingrese el codigo de la persona a ELIMINAR: ");
                        VectorAmigos.eliminarAmigo(codigo);
                        break;
                    case 6:
                        Console.WriteLine("\t\nFIN PROGRAMA");
                        break;
                    default:
                        Console.WriteLine("\nOPCIÓN NO VÁLIDA");
                        break;
                }

            } while (op != 6);
        }
    }
}
