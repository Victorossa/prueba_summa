using System.Collections.Generic;

namespace PruebaTecnicaSuma
{

    public interface IAgent
    {
        // Función para calcular el resultado específico del agente
        double CalculateResult(List<double> data);

        // Función para obtener la representación en cadena de una escalera según la lógica específica del agente
        string GetStaircase(int n);
    }
}

