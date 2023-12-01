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
        public M8(string id, string ubicacionActual)
            : base(id, new Bateria(12250), 250, 30, ubicacionActual) // 30 es un ejemplo de velocidad óptima
        {
        }
    }
}
