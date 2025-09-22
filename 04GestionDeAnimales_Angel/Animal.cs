using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales_Angel
{
    internal class Animal
    {
        public String nombre { get; set; }
        public String raza { get; set; }
        public int edad { get; set; }

        public Animal(String nombre, String raza, int edad)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.edad = edad;
        }

    }
}