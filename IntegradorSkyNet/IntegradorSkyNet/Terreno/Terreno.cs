using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorSkyNet.Terreno
{
    public class Terreno
    {
        private const char TerrenoComun = '.';
        private const char Vertedero = '#';
        private const char Lago = '~';
        private const char VertederoElectronico = '@';
        private const char Cuartel = 'C';
        private const char SitioReciclaje = 'R';

        private char[,] terreno;

        public Terreno()
        {
            terreno = new char[30, 30];
            GenerarTerreno();
        }

        public void GenerarTerreno()
        {
            Random random = new Random();
            int cuarteles = 0, sitiosReciclaje = 0;
            int maxCuarteles = 5;
            int maxSitiosReciclaje = 15;

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    char tipoTerreno;
                    int probabilidad = random.Next(0, 100);

                    if (probabilidad < 5 && cuarteles < maxCuarteles)
                    {
                        tipoTerreno = Cuartel;
                        cuarteles++;
                    }
                    else if (probabilidad < 10 && sitiosReciclaje < maxSitiosReciclaje)
                    {
                        tipoTerreno = SitioReciclaje;
                        sitiosReciclaje++;
                    }
                    else if (probabilidad < 15)
                        tipoTerreno = Vertedero;
                    else if (probabilidad < 20)
                        tipoTerreno = Lago;
                    else if (probabilidad < 25)
                        tipoTerreno = VertederoElectronico;
                    else
                        tipoTerreno = TerrenoComun;

                    terreno[i, j] = tipoTerreno;
                }
            }
        }


        public void MostrarTerreno()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Write(terreno[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nReferencias terreno:");
            Console.WriteLine("TerrenoComun .");
            Console.WriteLine("Vertedero #");
            Console.WriteLine("Lago ~");
            Console.WriteLine("VertederoElectronico @");
            Console.WriteLine("Cuartel C");
            Console.WriteLine("SitioReciclaje R");

        }


    }
}