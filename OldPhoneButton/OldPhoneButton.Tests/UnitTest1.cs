using System.Text;
using Xunit;

namespace OldPhoneButton.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturningWordData()
        {
            // Arrange
            string input = "222#"; 
            string expectedOutput = "C";

            // Act
            string actualOutput = OldPhoneButton.Program.OldPhonePad(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void MapInputTest()
        {
            // Arrange
            var input = "4433555#";
            string expectedOutput = "44 33 555 ";

            // Act
            var actualOutput = OldPhoneButton.Program.MapInput(input);
            //var result = Equals(expectedOutput, actualOutput);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void CheckLastNumberTest()
        {
            // Arrange
            var lastNumber = new System.Text.StringBuilder("9999");
            int i = 3; // Last index
            string expectedOutput = "9999 ";

            // Act
            string actualOutput = OldPhoneButton.Program.CheckLastNumber(lastNumber, i);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void DeleteNumberTest()
        {
            // Arrange
            var arrayNumber = new System.Text.StringBuilder("227*");
            StringBuilder expectedOutput = new StringBuilder("22");

            // Act
            var newArray = OldPhoneButton.Program.DeleteNumber(arrayNumber);

            // Assert
            Assert.Equal(expectedOutput.ToString(), newArray.ToString());
        }
    }
}