using System.Text;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PruebaTecnicaSuma
{

    public class AgentC : IAgent
    {
        public double CalculateResult(List<double> data)
        {
            // Verificar si hay datos para evitar la división por cero
            if (data == null || data.Count == 0)
            {
                throw new ArgumentException("La lista de datos no puede ser nula o vacía.");
            }

            // Ordenar la lista de datos
            List<double> sortedData = data.OrderBy(x => x).ToList();

            // Calcular la mediana
            int middleIndex = sortedData.Count / 2;
            double median = (sortedData.Count % 2 == 0)
                ? (sortedData[middleIndex - 1] + sortedData[middleIndex]) / 2.0
                : sortedData[middleIndex];

            return median;
        }

        public string GetStaircase(int n)
        {
            // Verificar restricciones
            if (n <= 0 || n >= 100)
            {
                throw new ArgumentOutOfRangeException("El tamaño de la escalera debe estar entre 0 y 100.");
            }

            // Imprimir la escalera alineada al centro
            string staircase = "";
            int half = n / 2;

            for (int i = 0; i < n; i++)
            {
                string spaces = new string(' ', Math.Abs(half - i));
                string hashtags = new string('#', n - 2 * Math.Abs(half - i));
                staircase += spaces + hashtags + "\n";
            }

            return staircase;
        }
    }
}

