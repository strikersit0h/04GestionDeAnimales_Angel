using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales_Angel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal gestor = new Animal("Gestor", "N/A", 0); // Gestor de la lista
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n=== Menú de Animales ===");
                Console.WriteLine("1. Agregar Perro");
                Console.WriteLine("2. Buscar Animal");
                Console.WriteLine("3. Eliminar Animal");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.Write("Ingrese el nombre del perro: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese la raza del perro: ");
                    string raza = Console.ReadLine();

                    int edad = -1;
                    bool esperandoEdad = true;
                    while (esperandoEdad)
                    {
                        Console.Write("Ingrese la edad del perro: ");
                        if (int.TryParse(Console.ReadLine(), out edad) && edad >= 0)
                        {
                            esperandoEdad = false;
                        }
                        else
                        {
                            Console.WriteLine("Edad inválida. Intente de nuevo.");
                        }
                    }

                    Perro perro = new Perro(nombre, raza, edad);
                    gestor.agregarAnimal(perro);
                    Console.WriteLine("Perro agregado con éxito.");
                }
                else if (opcion == "2")
                {
                    Console.Write("Ingresa el nombre del animal a buscar: ");
                    string nombreBuscar = Console.ReadLine();
                    gestor.buscarAnimal(nombreBuscar);
                }
                else if (opcion == "3")
                {
                    Console.Write("Ingresa el nombre del animal a eliminar: ");
                    string nombreEliminar = Console.ReadLine();
                    gestor.eliminarAnimal(nombreEliminar);
                }
                else if (opcion == "4")
                {
                    Console.WriteLine("Saliendo del programa...");
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intentalo de nuevo.");
                }
            }
        }
    }
}

