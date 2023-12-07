using IntegradorSkyNet.Operadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorSkyNet
{
    public class Helpers


    {
    
       public static List<Operador> operadores = new List<Operador>();
        
        
        static public void ListarOperadores(List<Operador> op)
        {
            Console.Clear();
            Console.WriteLine("estos son los operadores:");
            foreach (var operador in op)
            {
                Console.WriteLine(operador.ID); // Asegúrate de que la clase Operador tenga un método ToString adecuado.
            }
        }

        
        public static void AgregarOperadorK9(List<Operador> operadores)
        {
            Console.Clear();
            // Crear un nuevo operador K9
            K9 nuevoK9 = new K9("Ubicación inicial de K9");
            operadores.Add(nuevoK9);
            Console.WriteLine($"Operador K9 creado con ID: {nuevoK9.ID}");
        }

        public static void AgregarOperadorM8(List<Operador> operadores)
        {
            Console.Clear();
            // Crear un nuevo operador M8
            M8 nuevoM8 = new M8("Ubicación inicial de M8");
            operadores.Add(nuevoM8);
            Console.WriteLine($"Operador M8 creado con ID: {nuevoM8.ID}");
        }

        public static void AgregarOperadorUAV(List<Operador> operadores)
        {
            Console.Clear();
            // Crear un nuevo operador UAV
            UAV nuevoUAV = new UAV("Ubicación inicial de UAV");
            operadores.Add(nuevoUAV);
            Console.WriteLine($"Operador UAV creado con ID: {nuevoUAV.ID}");
        }

    }
}




/* 
static void RemoverOperador()
{
   Console.WriteLine("Remover operador.");

   ListarOperadores();

   Console.Write("Ingrese el ID del operador a remover: ");
   int id;
   bool esNumero = int.TryParse(Console.ReadLine(), out id);

   if (!esNumero)
   {
       Console.WriteLine("Por favor, ingrese un número válido.");
       return;
   }

   // Buscar el operador con el ID dado
   var operadorARemover = operadores.FirstOrDefault(o => o.Id == id);

   if (operadorARemover != null)
   {
       operadores.Remove(operadorARemover);
       Console.WriteLine("Operador removido exitosamente.");
   }
   else
   {
       Console.WriteLine("No se encontró un operador con el ID especificado.");
   }
}
}








static void ListarOperadoresConEstado()
{
foreach (var operador in operadores)
{
   Console.WriteLine(operador.ToString()); // Asegúrate de que el método ToString de Operador incluya la información de la batería.
}
}

static void SeleccionarYEnviarOperador()
{
// Mostrar todos los operadores para que el usuario pueda elegir
ListarOperadores();

Console.Write("Ingrese el ID del operador a mover: ");
string id = Console.ReadLine();

// Buscar el operador con el ID dado
var operadorAEnviar = operadores.FirstOrDefault(o => o.ID == id);

if (operadorAEnviar == null)
{
Console.WriteLine("No se encontró un operador con el ID especificado.");
return;
}

// Solicitar nueva ubicación
Console.Write("Ingrese la nueva coordenada X: ");
int nuevoX = int.Parse(Console.ReadLine()); // Considera agregar validación aquí

Console.Write("Ingrese la nueva coordenada Y: ");
int nuevoY = int.Parse(Console.ReadLine()); // Considera agregar validación aquí

// Crear una nueva instancia de Localizacion
Localizacion nuevaLocalizacion = new Localizacion(nuevoX, nuevoY);

// Actualizar la ubicación del operador
operadorAEnviar.MoverALocalizacion(nuevaLocalizacion);

Console.WriteLine($"Operador {id} movido a la nueva ubicación: X = {nuevoX}, Y = {nuevoY}");
}

static void RetornarAlCuartel()
{
// Mostrar todos los operadores para que el usuario pueda elegir
ListarOperadores();

Console.Write("Ingrese el ID del operador para retornar al cuartel: ");
string id = Console.ReadLine();

// Buscar el operador con el ID dado
var operador = operadores.FirstOrDefault(o => o.ID == id);

if (operador == null)
{
Console.WriteLine("No se encontró un operador con el ID especificado.");
return;
}

// Actualizar la ubicación del operador a la del cuartel
operador.MoverALocalizacion(Configuracion.UbicacionCuartel);

Console.WriteLine($"Operador {id} ha retornado al cuartel.");
}


static void ListarOperadoresPorLocalizacion()
{
Console.Write("Ingrese la coordenada X de la localización: ");
int x = int.Parse(Console.ReadLine()); // Considera agregar validación aquí

Console.Write("Ingrese la coordenada Y de la localización: ");
int y = int.Parse(Console.ReadLine()); // Considera agregar validación aquí

var operadoresEnLocalizacion = operadores.Where(o => o.UbicacionActual.X == x && o.UbicacionActual.Y == y).ToList();

if (operadoresEnLocalizacion.Any())
{
Console.WriteLine($"Operadores en la localización ({x}, {y}):");
foreach (var operador in operadoresEnLocalizacion)
{
   Console.WriteLine(operador.ToString()); // Asegúrate de que la clase Operador tenga un método ToString adecuado.
}
}
else
{
Console.WriteLine("No hay operadores en la localización especificada.");
}
}

static void TotalRecall()
{
foreach (var operador in operadores)
{
operador.MoverALocalizacion(Configuracion.UbicacionCuartel);
}

Console.WriteLine("Todos los operadores han retornado al cuartel.");
}
}

*/


