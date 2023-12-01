using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorSkyNet
{

    public class Localizacion
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Localizacion(int x, int y)
        {
            X = x;
            Y = y;
        }

        // actualizar la ubicación
        public void Mover(int nuevoX, int nuevoY)
        {
            X = nuevoX;
            Y = nuevoY;
        }

        // calcular la distancia entre dos localizaciones
        public static double CalcularDistancia(Localizacion loc1, Localizacion loc2)
        {
            return Math.Sqrt(Math.Pow(loc2.X - loc1.X, 2) + Math.Pow(loc2.Y - loc1.Y, 2));
        }


        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

}

