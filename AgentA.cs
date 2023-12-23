using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaTecnicaSuma
{

    public class AgentA : IAgent
    {
        public double CalculateResult(List<double> data)
        {
            // Verificar si hay datos para evitar la división por cero
            if (data == null || data.Count == 0)
            {
                throw new ArgumentException("La lista de datos no puede ser nula o vacía.");
            }

            // Calcular la media aritmética
            double average = data.Sum() / data.Count;

            return average;
        }

        public string GetStaircase(int n)
        {
            // Verificar restricciones
            if (n <= 0 || n >= 100)
            {
                throw new ArgumentOutOfRangeException("El tamaño de la escalera debe estar entre 0 y 100.");
            }

            // Imprimir la escalera
            string staircase = "";
            for (int i = 1; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string hashtags = new string('#', i);
                staircase += spaces + hashtags + "\n";
            }

            return staircase;
        }
    }
}
