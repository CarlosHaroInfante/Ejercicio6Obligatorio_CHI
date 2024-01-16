using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Obligatorio.Servicios
{
    /// <summary>
    /// Implementación donde se encuentra la lógica del menú.
    /// <author>CHI - 16/01/2024</author>
    /// </summary>
    internal class  MenuImplementacion : MenuInterfaz
    {
        public int menu()
        {

            Console.WriteLine("-------------------");
            Console.WriteLine("Bienvenido, Elija una opción: ");
            Console.WriteLine("-------------------");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Dar alta un nuevo cliente");
            Console.WriteLine("[2] - Ordenar Clientes");
            Console.WriteLine("-------------------");


            int resultado = Convert.ToInt32(Console.ReadLine());

        return resultado;

        }
    }
}
