using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorSkyNet.Operadores
{
    //unidades cuadrúpedas
    public class K9 : Operador
    {
        private const double CapacidadCargaMaximaK9 = 5.0; // kg
        private const double VelocidadOptimaK9 = 10.0; // km/h, ejemplo

        public K9(string ubicacionActual)
            : base(new Bateria(4000), CapacidadCargaMaximaK9, VelocidadOptimaK9, ubicacionActual)
        {
            // Aquí puedes agregar más propiedades o métodos específicos de K9
        }

        // Métodos adicionales específicos de K9
    }
}
