using Ejercicio6Obligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Obligatorio.Servicios

/// <summary>
/// Implementación que contiene la lógica que da de alta al cliente y que lo ordena.
/// <author>CHI - 16/01/2024</author>
/// </summary>
{
    internal class AltaImplementacion : AltaInterfaz
    {

        public void altaCliente(List<ClienteDto> listaAntigua)
        {

            ClienteDto cliente = clientes();

            listaAntigua.Add(cliente);

        }

        public void ordenaCliente(List<ClienteDto> listaAntigua)
        {

           //ClienteDto cliente = clientes();
            

            if (listaAntigua.Count >= 3)
            {
               // foreach(ClienteDto datos in listaAntigua)
               {
                  // Console.WriteLine(datos.NombreCompletoCliente + datos.Edad);

                    for(int i = 0;i < listaAntigua.Count - 1; i++)
                    {
                        for (int j = 0; j < listaAntigua.Count - 1 - i; j++)
                        {

                            if (listaAntigua[j].Edad < listaAntigua[j + 1].Edad)
                            {
                                ClienteDto aux = listaAntigua[j];
                                listaAntigua[i] = listaAntigua[j + 1];
                                listaAntigua[j + 1] = aux;
                            }

                        }
                   //Console.WriteLine(listaAntigua[i].NombreCompletoCliente + listaAntigua[i].Edad);
                    }
                        
                
                }
                

            }
            else
            {
                Console.WriteLine("Sin clientes suficientes");
            }


        }
        /// <summary>
        /// Método privado de clienteDto para añadir los datos a la lista 
        /// <author>CHI - 16/01/2024</author>
        /// </summary>

        private ClienteDto clientes()
        { 

            ClienteDto cliente = new ClienteDto();

            Console.WriteLine("Id para el Cliente: ");
            cliente.IdCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nombre del Cliente: ");
            cliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("Apellidos del Cliente(Sin Espacios, estilo camelCase): ");
            cliente.ApellidosCliente = Console.ReadLine();

            Console.WriteLine("Edad del Cliente: ");
            cliente.Edad = Convert.ToInt32(Console.ReadLine());

            return cliente;
        }
    }
}
