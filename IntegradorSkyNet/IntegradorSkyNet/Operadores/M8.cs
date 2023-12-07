using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorSkyNet.Operadores
{
    //semi-humanoides de carga
    public class M8 : Operador
    {
        private const double CapacidadCargaMaximaM8 = 40.0; // kg
        private const double VelocidadOptimaM8 = 15.0; // km/h, valor hipotético

        public M8(string ubicacionActual)
            : base(new Bateria(6500), CapacidadCargaMaximaM8, VelocidadOptimaM8, ubicacionActual)
        {
            // Aquí puedes agregar más propiedades o métodos específicos de M8
        }

        // Métodos adicionales específicos de M8
    }

}
