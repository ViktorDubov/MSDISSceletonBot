using MainSceletonBot.Scripts.CommandSystem;
using Moq;

namespace MainSceletonBot.Tests.CommandSystemTests
{
  public class CommandHandlerTests
  {
    [Theory]
    [InlineData("AddWorker John")]
    [InlineData("RemoveWorker 12345")]
    [InlineData("AddNewTask Task1")]
    [InlineData("GetTaskStatus Task1")]
    [InlineData("CancelTask Task1")]
    public void Given_valid_message_When_parsed_Then_returns_true(string _message)
    {
      // Arrange
      var mockCommandHandler = new Mock<ICommandHandler>();
      object parsedContext = null;

      mockCommandHandler
          .Setup(handler => handler.TryParseMessageToCommandAndContext(_message, out parsedContext))
          .Returns(true);

      // Act
      var result = mockCommandHandler.Object.TryParseMessageToCommandAndContext(_message, out parsedContext);

      // Assert
      Assert.True(result);
    }

    [Theory]
    [InlineData("InvalidCommand")]
    [InlineData("")]
    [InlineData(" ")]
    public void Given_invalid_message_When_parsed_Then_returns_false(string _message)
    {
      // Arrange
      var mockCommandHandler = new Mock<ICommandHandler>();
      object parsedContext = null;

      mockCommandHandler
          .Setup(handler => handler.TryParseMessageToCommandAndContext(_message, out parsedContext))
          .Returns(false);

      // Act
      var result = mockCommandHandler.Object.TryParseMessageToCommandAndContext(_message, out parsedContext);

      // Assert
      Assert.False(result);
    }
  }
}
