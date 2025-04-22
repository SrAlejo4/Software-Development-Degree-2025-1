using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaHerencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Programa calculo nómina";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            int op = 0, op1 = 0;

            do 
            {
                op = Int32.Parse(GeneralIo.lea("\tMenu Principal\n" +
                                            "1. Crear empleados\n" +
                                            "2. Manejar empleados\n" + 
                                            "3. Imprimir nómina\n" + 
                                            "0. Salir"));
                switch (op)
                {
                    case 0:
                        GeneralIo.imp("Fin del programa");
                        break;
                    case 1:
                        do
                        {
                            op1 = Int32.Parse(GeneralIo.lea("\tMenu Crear Empleado\n" +
                                                           "1. Empleados definidos\n" +
                                                           "2. Ingreso de Empleados\n" +
                                                           "3. Nuevo Empleado\n" +
                                                           "0. Salir"));
                            switch (op1)
                            {
                                case 1:
                                    GeneralNomina.empleadosDefinidos();
                                    break;
                                case 2:
                                    int tama = Int32.Parse(GeneralIo.lea("Ingrese la cantidad de empleados: "));
                                    GeneralNomina.ingresarEmpleados(tama);
                                    break;
                                case 3:
                                    GeneralNomina.nuevoEmpleado();
                                    break;
                                case 0:
                                    GeneralIo.imp("Regresando al principal ...");
                                    break;
                                default:
                                    break;
                            }
                        } while (op1 != 0); 

                        break;

                    case 2:
                        do
                        {
                            op1 = Int32.Parse(GeneralIo.lea("Menu manejo de empleados\n" + 
                                                                                "1. Consulta empleado por código\n" + 
                                                                                "2. Consulta de empleado por nombre\n" + 
                                                                                "3. Eliminar empleado\n" + 
                                                                                "4. Actualizar empleado\n" + 
                                                                                "0. Regresar al principio"));

                            switch (op1) 
                            {
                                case 1:
                                    int codigo = Int32.Parse(GeneralIo.lea("Ingrese la cedula del empleado: "));
                                    GeneralNomina.consultarCodigo(codigo);
                                    break;
                                case 2:
                                    string nombre = GeneralIo.lea("Ingrese el nombre del empleado: ");
                                    GeneralNomina.consultarNombre(nombre);
                                    break;
                                case 3:
                                    codigo = Int32.Parse(GeneralIo.lea("Ingrese la cedula del empleado: "));
                                    GeneralNomina.eliminarCodigo(codigo);
                                    break;
                                case 4:
                                    break;
                                case 0:
                                    break;
                                default:
                                    break;
                            }while (op1 != 0) ;
                            
                        } while (op1 != 0);
                        break;
                    case 3:
                        GeneralNomina.impNomina();
                        break;
                    default:
                        GeneralIo.imp("Error opción no válida");
                        break;
                }
            }while (op != 0);

        }
    }
}
