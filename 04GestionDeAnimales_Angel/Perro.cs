using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales_Angel
{
    internal class Perro: Animal
    {
   
        public Perro(string nombre, String raza, int edad): base(nombre, raza, edad)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.edad = edad;
        }

        public void ladrar()
        {
            Console.WriteLine("Guau Guau");
        }
    }
}
