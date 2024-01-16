using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Obligatorio.Dtos
{
    /// <summary>
    /// Clase que contiene los atributos que definirá al clinete.
    /// <author>CHI - 16/01/2024</author>
    /// </summary>
    internal class ClienteDto
    {
        int idCliente = 0;
        string nombreCliente = "aaaaa";
        string apellidosCliente = "aaaaa";
        string nombreCompletoCliente = "aaaaa";
        int edad = 0;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }
        
        public ClienteDto(int idCliente, string nombreCliente, string apellidosCliente,  int edad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.edad = edad;
        }


        public ClienteDto() { }

        override
            public string ToString()
        {
            string nom = 
                " Nombre Completo: " + this.NombreCliente + this.apellidosCliente +
                " Edad: " + this.edad;
            return nom;
        }
    }
}
