using Ejercicio6Obligatorio.Dtos;
using Ejercicio6Obligatorio.Servicios;

namespace Ejercicio6Obligatorio
{
    /// <summary>
    /// Class Program donde se encuentra el metodo main de nuestra app.
    /// <author>CHI - 16/01/2024</author>
    /// </summary>

    class Program
    {
        /// <summary>
        /// Método Main donde se encuentran las llamadas a métodos, un while y un switch para 
        /// el menú este operativo.
        /// <author>CHI - 16/01/2024</author>
        /// </summary>
        static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion();
            List<ClienteDto> clientes = new List <ClienteDto>();
            AltaInterfaz alta = new AltaImplementacion();

            bool cerrarMenu = false;


            while (!cerrarMenu)
            {
                int opcion = mi.menu();


                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Se cerrará el menú");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Alta Cliente");
                        alta.altaCliente(clientes);
                        foreach (ClienteDto cliente in clientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        } //prueba
                        break;
                    case 2:
                        Console.WriteLine("Ordenar lista de clientes");
                        alta.ordenaCliente(clientes);
                        foreach (ClienteDto datos in clientes)
                        {
                            Console.WriteLine(datos.ToString());

                        }
                        break;
                    default: 
                        Console.WriteLine("Ninguna opción válida");
                        break;
                        
                }
            }






        }




    }





}
