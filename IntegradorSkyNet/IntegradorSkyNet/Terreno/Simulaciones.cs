using IntegradorSkyNet.Datos;
using IntegradorSkyNet.Operadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorSkyNet.Terreno
{
    public class Simulaciones
    {

        public static void CargarSimulacion()
        {
            try
            {
                EstadoSimulacion estadoSimulacion = GestorDeSimulacion.CargarEstado("simulacion.json");
                // codigo para continuar con la simulacion cargada...
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar la simulación: {ex.Message}");
            }
        }

        public static void GenerarYSalvarSimulacion()
        {
            EstadoSimulacion estadoSimulacion = GenerarNuevaSimulacion();
            GestorDeSimulacion.GuardarEstado("simulacion.json", estadoSimulacion);
            //  iría el codigo para continuar con la nueva simulacion...
        }

        public static EstadoSimulacion GenerarNuevaSimulacion()
        {
            // Implementar la logica para generar una nueva simulación aquí.
            return new EstadoSimulacion
            {
                Terreno = new char[10, 10], // Asignar valores iniciales según sea necesario.
                Operadores = new List<Operador>() // Asignar operadores iniciales si es necesario.
            };
        }
    }
}
