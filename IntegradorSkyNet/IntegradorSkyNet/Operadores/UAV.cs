using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorSkyNet.Operadores
{
    //drones voladores
    public class UAV : Operador
    {
        private const double CapacidadCargaMaximaUAV = 250.0; // kg
        private const double VelocidadOptimaUAV = 25.0; // km/h, valor hipotético

        public UAV(string ubicacionActual)
            : base(new Bateria(12250), CapacidadCargaMaximaUAV, VelocidadOptimaUAV, ubicacionActual)
        {
            // Aquí puedes agregar más propiedades o métodos específicos de UAV
        }

        // Métodos adicionales específicos de UAV
    }
}
