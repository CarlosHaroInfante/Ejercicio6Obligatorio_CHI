using Ejercicio6Obligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Obligatorio.Servicios
{
    /// <summary>
    /// Interdaz donde se encontrarán los métodos que darán alta al cliente y ordenará a estos.
    /// <author>CHI - 16/01/2024</author>
    /// </summary>
    internal interface AltaInterfaz
    {
        /// <summary>
        /// Método que dará de alta al cliente
        /// <author>CHI - 16/01/2024</author>
        /// </summary>
        public void altaCliente(List<ClienteDto> listaAntigua);

        /// <summary>
        /// Método que ordenará los clientes cuando sean mayor a 3.
        /// <author>CHI - 16/01/2024</author>
        /// </summary>
        public void ordenaCliente(List<ClienteDto> listaAntigua);
    }
}
