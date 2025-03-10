using System;
using System.Collections.Generic;

namespace Implementacionde_una_lista_interactiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            int opcion;

            while (true)
            {
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1. Agregar Elemento");
                Console.WriteLine("2. Eliminar Elemento");
                Console.WriteLine("3. Mostrar Lista");
                Console.WriteLine("4. Salir");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    continue;
                }

                if (opcion == 4)
                {
                    break;
                }

                switch (opcion)
                {
                    case 1:
                        lista.Add(Console.ReadLine());
                        break;
                    case 2:
                        lista.Remove(Console.ReadLine());
                        break;
                    case 3:
                        foreach (var item in lista)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                }
            }
        }
    }
}