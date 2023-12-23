using System;

namespace PruebaTecnicaSuma
{
    public class AgentProvider
    {
        public static IAgent GetAgent(string name)
        {
            switch (name)
            {
                case "A":
                    return (IAgent)new AgentA();
                case "B":
                    return (IAgent)new AgentB();
                case "C":
                    return (IAgent)new AgentC();
                default:
                    throw new ArgumentException("Invalid agent name");
            }
        }

    }
}
