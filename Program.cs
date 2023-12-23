using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        // Función para imprimir una escalera de tamaño n
        static void ImprimirEscalera(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string espacios = new string(' ', n - i);
                string escalon = new string('#', i);
                Console.WriteLine(espacios + escalon);
            }
        }
    }

    class AgenteA
        {
            public double ObtenerMediaAritmetica(double[] datos)
            {
                return datos.Length > 0 ? datos.Average() : 0;
            }
        }

        class AgenteB
        {
            public double ObtenerMediaArmonica(double[] datos)
            {
                if (datos.Length == 0)
                    return 0;

                double sumaInversos = datos.Sum(dato => 1 / dato);
                return datos.Length / sumaInversos;
            }
        }

        class AgenteC
        {
            public double ObtenerMediana(double[] datos)
            {
                if (datos.Length == 0)
                    return 0;

                double[] datosOrdenados = datos.OrderBy(dato => dato).ToArray();
                int n = datosOrdenados.Length;

                if (n % 2 == 0)
                {
                    // Cantidad de datos par
                    int medio1 = n / 2 - 1;
                    int medio2 = n / 2;
                    return (datosOrdenados[medio1] + datosOrdenados[medio2]) / 2;
                }
                else
                {
                    // Cantidad de datos impar
                    int medio = n / 2;
                    return datosOrdenados[medio];
                }
            }
        }
    }

