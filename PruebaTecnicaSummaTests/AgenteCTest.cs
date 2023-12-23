using PruebaTecnicaSuma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PruebaTecnicaSummaTests
{
    public class AgenteCTest
    {

        [Fact]
        public void CalculateResult_ValidData_ReturnsMedian()
        {
            // Arrange
            var agentC = new AgentC();
            var data = new List<double> { 3, 1, 4, 1, 5, 9, 2, 6, 9 };

            // Act
            var result = agentC.CalculateResult(data);

            // Assert
            Assert.Equal(4, result, 1); // Tolerancia de 1 para manejar posibles errores de redondeo
        }

        [Fact]
        public void CalculateResult_EmptyData_ThrowsArgumentException()
        {
            // Arrange
            var agentC = new AgentC();
            var emptyData = new List<double>();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => agentC.CalculateResult(emptyData));
        }

        [Theory]
        [InlineData(null)]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(101)]
        public void GetStaircase_InvalidN_ThrowsArgumentException(int n)
        {
            // Arrange
            var agentC = new AgentC();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => agentC.GetStaircase(n));
        }

        [Fact]
        public void GetStaircase_ValidN_ReturnsStaircase()
        {
            // Arrange
            var agentC = new AgentC();
            var n = 2;

            // Act
            var result = agentC.GetStaircase(n);

            // Assert
            var expectedResult = ".##\n####\n.##\n..\n...\n....\n"; 
            Assert.Equal(expectedResult, result);
        }
    }
}

