using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Persona()
        {

        }
        public Persona(string nombre, string apellidoPaterno, string apellidoMaterno, string direccion, string telefono, string correo)
        
        {
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
        }
    }
}