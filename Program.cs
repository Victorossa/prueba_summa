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
            TestAgent(agentC, new List<double> { 3, 1, 4, 1, 5, 9, 2, 6 });

            Console.ReadKey();

        }

        static void TestAgent(IAgent agent, List<double> data)
        {
            // Calcular y mostrar el resultado del agente
            double result = agent.CalculateResult(data);
            Console.WriteLine($"Resultado: {result}");

            // Imprimir la escalera
            Console.WriteLine("Escalera:");
            Console.WriteLine(agent.GetStaircase(6));  // Cambia el tamaño según tus necesidades
            Console.WriteLine();
        }
    }
}
