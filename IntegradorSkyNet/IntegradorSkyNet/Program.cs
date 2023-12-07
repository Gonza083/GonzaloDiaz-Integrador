using IntegradorSkyNet.Operadores;
using IntegradorSkyNet.Terreno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace IntegradorSkyNet
{
    internal class Program

    {


        
       public static void Main(string[] args)
        {
            Terreno.Terreno terreno = new Terreno.Terreno();


            List<Operador> operadores = new List<Operador>();

            Menu.MostrarMenu(operadores, terreno);
        }


    } 
}


/*
 *  static void Main(string[] args)
        {
            Terreno.Terreno terreno = new Terreno.Terreno();
            List<Operador> operadores = new List<Operador>();
            operadores.Add(new K9("kapo", "x;y"));
           
            


            int opcion;
            do
            {
                Console.WriteLine("Menú de Operadores");
                Console.WriteLine("1) Listar estado de todos los operadores");
                Console.WriteLine("2) Agregar operador");
                Console.WriteLine("3) Remover operador");
                Console.WriteLine("4) Salir");
                Console.Write("Seleccione una opción: ");

                Console.Write("\nElija una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

 
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("listando operadoresss");
                        Helpers.ListarOperadores(operadores);
                        break;
                    case 2:
                       // Helpers.AgregarOperador(operadores);
                        break;
                    case 3:
                        //RemoverOperador();
                        break;
                    case 4:
                        //continuar = false;
                        break;
                    case 5:
                       // ListarOperadoresConEstado();
                        break;
                    case 6: 
                       // SeleccionarYEnviarOperador();
                        break;
                    case 7:
                        // RetornarAlCuartel();
                        break;
                    case 8:
                       // ListarOperadoresPorLocalizacion();
                        break;
                     case 9:
                       // TotalRecall();

                    break;
                    case 10:
                       terreno.GenerarTerreno();
                        Console.WriteLine("Terreno generado.");
                        break;
                    case 11:
                        terreno.MostrarTerreno();
                        break;
                    case 12:
                        Simulaciones.CargarSimulacion();
                        break;
                    case 13:
                        Simulaciones.GenerarYSalvarSimulacion();
                        break;



                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }


            } while (opcion >= 1 && opcion <= 14);
        }
*/
