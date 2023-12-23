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
            if (n < 1 || n > 100)
            {
                throw new ArgumentException("El valor de n debe estar entre 1 y 100");
            }

            int lineaCent = (n * 2) + 2;
            int espacios = (lineaCent / 2) - 2;
            int simbolos = espacios + 1;

            string escalera = "";

            for (int i = 0; i < lineaCent; i++)
            {
                string linea = "";
                for (int j = 0; j < espacios; j++)
                {
                    linea += ".";
                }
                for (int j = 0; j < simbolos; j++)
                {
                    linea += "#";
                }
                escalera += linea + "\n";

                // Actualiza espacios y símbolos
                if (i < n - 1)
                {
                    espacios--;
                    simbolos += 2;
                }
                else
                {
                    espacios++;
                    simbolos -= 2;
                }
            }

            return escalera;
        }

    }
}

