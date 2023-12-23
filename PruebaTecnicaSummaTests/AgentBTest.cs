using PruebaTecnicaSuma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PruebaTecnicaSummaTests
{
    public class AgentBTest
    {

        [Fact]
        public void CalculateResult_ReturnsCorrectHarmonicMean()
        {
            //CALCULA LA MEDIA ARMONICA DE LA SERIE DE DATOS
            // Arrange
            var agentB = new AgentB();
            var data = new List<double> { 1, 2, 3, 4, 5 };

            // Act
            var result = agentB.CalculateResult(data);

            // Assert
            Assert.Equal(2.18978102189781, result, 5); // Assert with precision up to 5 decimal places
        }

        [Fact]
        public void CalculateResult_ThrowsArgumentExceptionForNullData()
        {
            // SI RECIBE NULL
            // Arrange
            var agentB = new AgentB();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => agentB.CalculateResult(null));
        }

        [Fact]
        public void CalculateResult_ThrowsArgumentExceptionForEmptyData()
        {
            // SI LA LISTA ESTA VACIA
            // Arrange
            var agentB = new AgentB();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => agentB.CalculateResult(new List<double>()));
        }

        [Fact]
        public void GetStaircase_ThrowsArgumentOutOfRangeExceptionForInvalidSize()
        {
            // VALIDA LOS POSIBLES VALORES PARA n
            // Arrange
            var agentB = new AgentB();

            // Act y el Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => agentB.GetStaircase(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => agentB.GetStaircase(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => agentB.GetStaircase(101));
        }

        [Fact]
        public void GetStaircase_ReturnsCorrectStaircase()
        {
            // Arrange
            var agentB = new AgentB();
            var expectedStaircase = "####\n ###\n  ##\n   #\n";
            // Act
            var result = agentB.GetStaircase(4);

            // Assert
            Assert.Equal(expectedStaircase, result);
        }
    }
}

