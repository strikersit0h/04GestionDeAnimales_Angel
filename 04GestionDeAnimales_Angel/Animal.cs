using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales_Angel
{
    internal class Animal
    {

        List<Animal> listaAnimales = new List<Animal>();
        public String nombre { get; set; }
        public String raza { get; set; }
        public int edad { get; set; }

        public Animal(String nombre, String raza, int edad)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.edad = edad;
        }

        public void agregarAnimal(Animal animal)
        {
            listaAnimales.Add(animal);
        }

        public void buscarAnimal(string nombre)
        {
            bool encontrado = false;  // Booleano para verificar si se ha encontrado a el animal.

            foreach (Animal animal in listaAnimales)
            {
                if (animal.nombre == nombre && !encontrado)
                {
                    Console.WriteLine("Animal encontrado: " + animal.nombre +
                                      ", Raza: " + animal.raza +
                                      ", Edad: " + animal.edad);
                    encontrado = true; // Se ha encontrado a el animal.
                }
            }

            if (!encontrado)  // Si no ha sido encontrado.
            {
                Console.WriteLine("Animal no encontrado");
            }
        }

        public void eliminarAnimal(string nombre)
        {
            Animal animalAEliminar = null;

            foreach (Animal animal in listaAnimales)
            {
                if (animal.nombre == nombre && animalAEliminar == null)
                {
                    animalAEliminar = animal;
                }
            }

            if (animalAEliminar != null)
            {
                listaAnimales.Remove(animalAEliminar);
                Console.WriteLine("Animal eliminado: " + animalAEliminar.nombre);
            }
            else
            {
                Console.WriteLine("Animal no encontrado");
            }
        }
    }
}