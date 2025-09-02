namespace FireSafetyDesigner.Tests;

using FireSafetyDesigner.Core;

public class UnitTest1
{
    [Fact]
    public void GetMessage_ReturnsExpectedString()
    {
        // Arrange
        Class1 core = new Class1();
        string expectedMessage = "Hello from FireSafetyDesigner.Core!";

        // Act
        string actualMessage = core.GetMessage();

        // Assert
        Assert.Equal(expectedMessage, actualMessage);
    }
}