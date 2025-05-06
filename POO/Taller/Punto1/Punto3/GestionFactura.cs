using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    public class GestionFactura
    {
        private static Producto[] vectorProductos = new Producto[10];
        public static Producto[] carrito;
        public static int posProducto = 0, posCarrito = 0;

        public static void crearProductos()
        {
            vectorProductos[0] = new Producto(1, "Frijoles", 3500, 30, 0);
            vectorProductos[1] = new Producto(2, "Arroz", 2200, 100, 0);
            vectorProductos[2] = new Producto(3, "Garbanzos", 4300, 75, 10);
            vectorProductos[3] = new Producto(4, "Café", 5600, 45, 5);
            vectorProductos[4] = new Producto(5, "Aceite", 9000, 60, 0);
            posProducto = 5;
        }

        public static void definirCarrito(int tam)
        {
            carrito = new Producto[tam];
        }

        public static void registrarProducto()
        {
            try
            {
                int cont = 0;
                while (cont < carrito.Length)
                {
                    bool encontrado = false;
                    Console.Write("\nIngrese el código del producto: ");
                    int codigo = Int32.Parse(Console.ReadLine());
                    Console.Write("Ingrese la cantidad: ");
                    int cantidad = Int32.Parse(Console.ReadLine());

                    for (int i = 0; i < posProducto; i++)
                    {
                        if (vectorProductos[i].Codigo == codigo)
                        {
                            carrito[posCarrito] = vectorProductos[i];
                            encontrado = true;

                            if (cantidad <= vectorProductos[i].Stock)
                            {
                                carrito[posCarrito].CantidadRegistro = cantidad;
                                posCarrito++;
                                cont++;

                                vectorProductos[i].Stock -= cantidad;
                            }
                            else
                            {
                                Console.Write("\nLa cantidad disponible de " + vectorProductos[i].Nombre + " es " + vectorProductos[i].Stock + " unidades ...");
                            }
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.Write("\nNo se encontró el producto");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Ingrese una tecla para regresar");
                Console.ReadKey();
            }
        }
        public static void imprimirProducto(Producto producto)
        {
            Console.Write("\nCódigo: " + producto.Codigo +
                                       "\nNombre: " + producto.Nombre +
                                       "\nValor unitario: " + producto.ValorUnitario +
                                       "\nCantidad: " + producto.CantidadRegistro +
                                       "\nDescuento: " + producto.calcularDescuento() + "\n");
        }


        public static void generarFactura()
        {
            double subTotal = 0, IVA = 0, totalFactura = 0;
            for (int i = 0; i < posCarrito; i++)
            {
                imprimirProducto(carrito[i]);
                subTotal += (carrito[i].calcularSubTotal() - carrito[i].calcularDescuento());
            }

            IVA = subTotal * 0.19;
            totalFactura = subTotal + IVA;

            Console.WriteLine("\n\nSubtotal: " + subTotal +
                                           "\nIVA: " + IVA +
                                           "\nTotal a pagar: " + totalFactura);

            posCarrito = 0;
            definirCarrito(0); // Limpiamos el Array y redifinimos su tamaño a cero . . .
        }

    }
}
