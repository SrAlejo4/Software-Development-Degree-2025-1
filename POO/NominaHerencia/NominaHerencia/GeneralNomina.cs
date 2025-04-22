using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaHerencia
{
    public class GeneralNomina
    {
        static int pos = 0, tam = 10;
        static Trabajador[] vecNomina = new Trabajador[10];
        static Trabajador obj = null;

        public static void empleadosDefinidos() 
        {
            vecNomina[0] = new Horas(123, "Juan", 10, 40, 40000);
            vecNomina[1] = new Salario(456, "Ana", 5, 2000000);
            vecNomina[2] = new Horas(251, "Pepe", 10, 50, 25000);
            vecNomina[3] = new Salario(372, "Luz", 5, 3000000);
            vecNomina[4] = new Horas(546, "Ana", 0, 20, 40000);
            pos = 5;
        }

        public static void ingresarEmpleados(int tama) 
        {
            vecNomina = new Trabajador[tama];
            pos = 0;
            tam = tama;
        }

        public static void nuevoEmpleado() 
        {
            vecNomina[pos] = GeneralIo.lea();
            pos++;
        }

        public static void impNomina() 
        {
            for (int i = 0; i < pos; i++)
            {
                GeneralIo.imp(vecNomina[i]);
            }
        }

        public static void consultarCodigo(int codigo) 
        {
            for (int i = 0; i < pos; i++) 
            {
                if (codigo == vecNomina[i].Cedula)
                {
                    GeneralIo.imp(vecNomina[i]);
                    return;
                }
            }
            GeneralIo.imp("Empleado NO encontrado");
        }

        public static void consultarNombre(string nombre)
        {
            bool encontrado = false;
            for (int i = 0; i < pos; i++)
            {
                if (nombre.Equals(vecNomina[i]))
                {
                    GeneralIo.imp(vecNomina[i]);
                    encontrado = true;  
                }
            }

            if (!encontrado) 
            {
                GeneralIo.imp("Empleado NO encontrado");
            }

        }

        public static void eliminarCodigo(int codigo)
        {
            for (int i = 0; i < pos; i++) 
            {
                if (codigo == vecNomina[i].Cedula)
                {
                    for (int j = i; j < pos; j++)
                    {
                        vecNomina[j] = vecNomina[j + 1];
                    }
                    pos--;
                    GeneralIo.imp("El empleado ha sido eliminado");
                    return;
                }
            }
        }
    }
}
