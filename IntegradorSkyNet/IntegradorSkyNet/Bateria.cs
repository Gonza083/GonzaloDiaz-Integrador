using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorSkyNet
{
    public class Bateria
    {
        public int Capacidad { get; private set; }  // Capacidad de la batería en mAh
        public int BateriaActual { get; private set; } // Carga actual de la batería en mAh

        // Constructor
        public Bateria(int capacidad)
        {
            Capacidad = capacidad;
            BateriaActual = capacidad; // Inicialmente la batería está completamente cargada
        }

        public override string ToString()
        {
            return $"Nivel de Carga: {BateriaActual}%";
        }
        // Método para consumir batería
        public void Consumir(int cantidad)
        {
            if (cantidad > BateriaActual)
            {
                throw new InvalidOperationException("No hay suficiente carga en la batería.");
            }

            BateriaActual -= cantidad;
        }

        // Método para recargar la batería
        public void Recargar()
        {
            BateriaActual = Capacidad;
        }

        // Método para transferir carga a otra batería
        public void TransferirCarga(Bateria otraBateria, int cantidad)
        {
            if (cantidad > BateriaActual)
            {
                throw new InvalidOperationException("No hay suficiente carga para transferir.");
            }

            otraBateria.BateriaActual += cantidad;
            BateriaActual -= cantidad;
        }

        // Método para obtener el porcentaje de batería restante
        public double PorcentajeCarga()
        {
            return (double)BateriaActual / Capacidad * 100;
        }
    }

}
