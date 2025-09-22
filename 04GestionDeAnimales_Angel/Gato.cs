using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales_Angel
{
    internal class Gato : Animal
    {
        public string nombre { get; set; }
        public string raza { get; set; }
        public int edad { get; set; }

        public Gato(string nombre, String raza, int edad) // Constructor
        {
            this.nombre = nombre;
            this.raza = raza;
            this.edad = edad;
        }

        public void maullar()
        {
            Console.WriteLine("Miaaau");
        }
    }
}
