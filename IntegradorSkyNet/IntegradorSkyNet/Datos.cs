using IntegradorSkyNet.Operadores;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace IntegradorSkyNet.Datos
{
    public class GestorDeSimulacion
    {
        public static void GuardarEstado(string archivo, EstadoSimulacion estado)
        {
            string jsonString = JsonSerializer.Serialize(estado);
            File.WriteAllText(archivo, jsonString);
        }

        public static EstadoSimulacion CargarEstado(string archivo)
        {
            string jsonString = File.ReadAllText(archivo);
            return JsonSerializer.Deserialize<EstadoSimulacion>(jsonString);
        }
    }

    public class EstadoSimulacion
    {
        public char[,] Terreno { get; set; }
        public List<Operador> Operadores { get; set; }
    }
}
