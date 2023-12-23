using System.Linq;
using System;
using System.Text;
using System.Collections.Generic;

namespace PruebaTecnicaSuma
{
    public class AgentB : IAgent
    {
        public double CalculateResult(List<double> data)
        {
            // Verificar si hay datos para evitar la división por cero
            if (data == null || data.Count == 0)
            {
                throw new ArgumentException("La lista de datos no puede ser nula o vacía.");
            }

            // Calcular la media armónica de la serie de datos
            double harmonicMean = data.Count / data.Sum(x => 1.0 / x);

            return harmonicMean;
        }

        public string GetStaircase(int n)
        {
            // Verificar restricciones
            if (n <= 0 || n >= 100)
            {
                throw new ArgumentOutOfRangeException("El tamaño de la escalera debe estar entre 0 y 100.");
            }

            // Imprimir la escalera alineada a la derecha
            string staircase = "";
            for (int i = 0; i < n; i++)
            {
                string spaces = new string(' ', i);
                string hashtags = new string('#', n - i);
                staircase += spaces + hashtags + "\n";
            }

            return staircase;
        }
    }
}
