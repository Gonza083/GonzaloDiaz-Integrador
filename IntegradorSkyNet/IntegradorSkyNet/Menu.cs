using IntegradorSkyNet.Operadores;
using IntegradorSkyNet.Terreno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorSkyNet
{
    internal class Menu
    {

        public static void MostrarMenu(List<Operador> operadores, Terreno.Terreno terreno)
        {
            int opcion;
            do
            {

                
                  Console.WriteLine("\nMenú de Operadores");
                Console.WriteLine("1) Cargar Simulación");
                Console.WriteLine("2) Generar Terreno");
                Console.WriteLine("3) Mostrar Terreno");
                Console.WriteLine("4) Generar y Salvar Simulación");
                Console.WriteLine("5) Listar todos los operadores");
                Console.WriteLine("6) Listar estado de todos los operadores");
                Console.WriteLine("7) Agregar operador");
                Console.WriteLine("8) Remover operador");
                Console.WriteLine("9) Salir");
  
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {

                    case 1:
                        Simulaciones.CargarSimulacion();
                        break;
                    case 2:
                         terreno.GenerarTerreno();
                         Console.WriteLine("Terreno generado.");
                         break;
                     case 3:
                         terreno.MostrarTerreno();
                         break;
                     case 4:
                        Simulaciones.GenerarYSalvarSimulacion();
                         break;
                    case 5:
                        Helpers.ListarOperadores(operadores);
                        break;
                    case 6:
                        // Implementa ListarEstados();
                        break;
                    case 7:
                        MostrarMenuOperadores(operadores);
                         break;
                    case 8:
                         // Implementa RemoverOperador();
                         break;
                    case 9:
                         Console.WriteLine("Saliendo del programa...");
                         return;
                    default:
                         Console.WriteLine("Opción no válida.");
                         break;
                        
                }

            } while (opcion != 4);


        }
        public static void MostrarMenuOperadores(List<Operador> operadores)
        {
            Console.WriteLine("Elige el tipo de operador a crear:");
            Console.WriteLine("1. K9");
            Console.WriteLine("2. M8");
            Console.WriteLine("3. UAV");
            // Leer la elección del usuario y llamar al método correspondiente
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
 
                  Helpers.AgregarOperadorK9(operadores);
                    break;
                case 2:

                    Helpers.AgregarOperadorM8(operadores);
                    break;
                case 3:
                    Helpers.AgregarOperadorUAV(operadores);
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}
