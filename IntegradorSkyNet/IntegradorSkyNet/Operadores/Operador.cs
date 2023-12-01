using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorSkyNet.Operadores
{
    public class Operador
    {
        public string ID { get; set; }
        public Bateria Bateria { get; protected set; }
        public string EstadoGeneral { get; set; }
        public double CapacidadCargaMaxima { get; protected set; }
        public double VelocidadOptima { get; protected set; }
        public string UbicacionActual { get; set; }

        public bool EstaDanado { get; set; }


        public bool EstaOcupado { get; set; }
        //public [,] Localizacion { get; set; }

        private double VelocidadInicial;

        public Operador(string id, Bateria bateria, double capacidadCargaMaxima, double velocidadOptima, string ubicacionActual)
        {
            ID = id; //haer funcin para generar id
            Bateria = bateria; //ver si esta relacionado bien con la calse bateria
            CapacidadCargaMaxima = capacidadCargaMaxima;
            VelocidadOptima = velocidadOptima;
            VelocidadInicial = velocidadOptima; //puesta una de ejemplo
            UbicacionActual = ubicacionActual;
        }

        public void Moverse(string nuevaUbicacion)
        {
            // Asumiendo que el movimiento consume batería
            Bateria.Consumir(10); // Ejemplo
            UbicacionActual = nuevaUbicacion;
            AjustarVelocidad();
            //ajustar esta funcion con la calse localizacion y consumo de bateria
        }

        protected void AjustarVelocidad()
        {
            double porcentajeBateria = Bateria.PorcentajeCarga();
            VelocidadOptima = VelocidadInicial * (1 - 0.05 * (100 - porcentajeBateria) / 10);
        }

        public override string ToString()
        {
            return $"ID: {ID} bateria : {Bateria}";

            // Incluir más detalles.
        }

       /*
        public void EjecutarOrdenGeneral(char[,] terreno, List<Localizacion> vertederos, List<Localizacion> sitiosReciclaje)
        {
            if (!EstaOcupado)
            {
                Localizacion vertederoMasCercano = EncontrarUbicacionMasCercana(UbicacionActual, vertederos);
                Mover(vertederoMasCercano);
                // Simular recogida de carga

                Localizacion sitioReciclajeMasCercano = EncontrarUbicacionMasCercana(UbicacionActual, sitiosReciclaje);
                Mover(sitioReciclajeMasCercano);
                // Simular entrega de carga
            }
        }

        private Localizacion EncontrarUbicacionMasCercana(Localizacion actual, List<Localizacion> ubicaciones)
        {
            // Implementa la lógica para encontrar la ubicación más cercana
        }

        private void Mover(Localizacion destino)
        {
            // Actualiza la ubicación actual del operador al destino
            UbicacionActual = destino;
        }

        private void Mover(Localizacion destino)
        {
            // Actualiza la ubicación actual del operador al destino
            UbicacionActual = destino;
        }


        /*public void MoverALocalizacion([,]Localizacion nuevaLocalizacion)
         {
             UbicacionActual = nuevaLocalizacion;
         }*/


        //metodos para agregar
        //transferir bateria
        //transferir carga fisica
        //volver al cuartel y transferir carga fisica
        //volver al cuartel y cargar bateria

    }

}
