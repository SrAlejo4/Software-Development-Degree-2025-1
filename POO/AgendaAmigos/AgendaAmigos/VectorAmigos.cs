using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAmigos
{
    public class VectorAmigos
    {
        private static ArrayList agendaAmigos = new ArrayList();

        public ArrayList getAgendaAmigos()
        {
            return agendaAmigos;
        }

        public static string leer(string mensaje)
        {
            Console.Write(mensaje);
            string dato = System.Console.ReadLine();
            return dato;
        }

        public static void agregarAmigo()
        {
            Amigo objAmigo = new Amigo();
            objAmigo.Codigo = leer("\nIngrese el código: ");
            objAmigo.Nombre = leer("Ingrese el nombre: ");
            objAmigo.Telefono = leer("Ingrese el teléfono: ");
            objAmigo.Correo = leer("Ingrese el correo:  ");
            objAmigo.Direccion = leer("Ingrese la dirección: ");
            agendaAmigos.Add(objAmigo);
        }

        public static void imprimirAmigo(Amigo objAmigo)
        {
            Console.WriteLine("\nCodigo: " + objAmigo.Codigo +
                                           "\nNombre: " + objAmigo.Nombre +
                                           "\nTeléfono: " + objAmigo.Telefono +
                                           "\nCorreo: " + objAmigo.Correo +
                                           "\nDirección: " + objAmigo.Direccion +
                                           "\n -------------------------------------------");
        }

        public static void imprimirAgenda()
        {
            foreach (Amigo A in agendaAmigos)
            {
                imprimirAmigo(A);
            }
        }

        public static void buscarAmigoCodigo(string codigo)
        {
            Amigo amigoEncontrado = new Amigo(); // Objeto temporal ...
            bool encontrado = false;
            foreach (Amigo A in agendaAmigos)
            {
                if (A.Codigo == codigo)
                {
                    amigoEncontrado = A;
                    encontrado = true;
                    imprimirAmigo(A);
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"\nNo se encontró una persona con el codigo {codigo}");
            }
        }

        public static void buscarAmigoNombre(string nombre)
        {
            Amigo amigoEncontrado = new Amigo(); // Objeto temporal ...
            bool encontrado = false;
            foreach (Amigo A in agendaAmigos)
            {
                if (A.Nombre == nombre)
                {
                    amigoEncontrado = A;
                    encontrado = true;
                    imprimirAmigo(A);
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"\nNo se encontró a una persona con el nombre {nombre} ");
            }
        }

        public static void eliminarAmigo(string codigo)
        {
            bool encontrado = false;
            foreach (Amigo A in agendaAmigos)
            {
                if (A.Codigo == codigo)
                {
                    agendaAmigos.Remove(A);
                    Console.WriteLine($"\n{A.Nombre} fue eliminado de la agenda ...");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"\nNo se encontró a una persona con el codigo {codigo} ");
            }
        } 
        // - - -
    }
}
