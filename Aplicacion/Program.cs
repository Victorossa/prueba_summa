using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaSuma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso con AgentA
            IAgent agentA = new AgentA();
            TestAgent(agentA, new List<double> { 2, 4, 6, 8, 10 });

            // Ejemplo de uso con AgentB
            IAgent agentB = new AgentB();
            TestAgent(agentB, new List<double> { 1, 2, 3, 4, 5 });

            // Ejemplo de uso con AgentC
            IAgent agentC = new AgentC();
            TestAgent(agentC, new List<double> { 3, 1, 4, 1, 5, 9, 2, 6 , 9});


            Console.ReadKey();

        }

        // Recibe como parametros una instancia de los agentes que implementan la interface y procesa segun lo que le llegue
        static void TestAgent(IAgent agent, List<double> data)
        {
            // FUNCIONALIDAD 1
            double result = agent.CalculateResult(data);
            Console.WriteLine($"Resultado: {result}");

            // FUNCIONALIDAD 2
            Console.Write("Ingrese el tamaño de la escalera: ");
            string inputSize = Console.ReadLine();

            if (int.TryParse(inputSize, out int size))
            {
                Console.WriteLine("Escalera:");
                Console.WriteLine(agent.GetStaircase(size));
            }
            else
            {
                Console.WriteLine("El tamaño de la escalera debe ser un número válido.");
            }

            Console.WriteLine();
        }

    }
}
