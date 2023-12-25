using PruebaTecnicaSuma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PruebaTecnicaSummaTests
{
    public class AgentATest
    {
        [Fact]
        public void CalculateResult_ValidData_ReturnsCorrectAverage()
        {

            // QUE CALCULE EL PROMEDIO
            // Arrange
            var agentA = new AgentA();
            var data = new List<double> { 2, 4, 6, 8, 10 };

            // Act
            var result = agentA.CalculateResult(data);

            // Assert
            Assert.Equal(6.0, result, 2); 
        }

        [Fact]
        public void CalculateResult_EmptyData_ThrowsArgumentException()
        {
            // SI NO EXISTEN DATOS O ESTA VACIO
            // Arrange
            var agentA = new AgentA();
            var emptyData = new List<double>();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => agentA.CalculateResult(emptyData));
        }

        [Fact]
        public void GetStaircase_ThrowsArgumentOutOfRangeExceptionForInvalidSize()
        {
            // VALIDA LOS POSIBLES VALORES PARA n
            // Arrange
            var agentB = new AgentA();

            // Act y el Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => agentB.GetStaircase(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => agentB.GetStaircase(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => agentB.GetStaircase(101));
        }

        [Fact]
        public void GetStaircase_ValidInput_ReturnsCorrectStaircase()
        {
            // ARMA UNA ESCALERA DE 5
            // Arrange
            var agentA = new AgentA();
            var n = 5;

            // Act
            var result = agentA.GetStaircase(n);

            // Assert
            var expectedStaircase = "    #\n   ##\n  ###\n ####\n#####\n";
            Assert.Equal(expectedStaircase, result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(100)]
        public void GetStaircase_InvalidInput_ThrowsArgumentOutOfRangeException(int invalidN)
        {
            // VALIDA EL RANGO QUE DEBE DE RECIBIR COMO PARAMETRO EL METODO
            // Arrange
            var agentA = new AgentA();

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => agentA.GetStaircase(invalidN));
        }
    }
}
