using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public string sexo;

        public Persona(string nombre, string apellido, string sexo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
        }
    }
}
