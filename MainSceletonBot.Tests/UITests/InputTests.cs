using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using MainSceletonBot.Scripts.UI;
using Moq;

namespace MainSceletonBot.Tests.UITests
{
  public class InputTests
  {
    [Theory]
    [InlineData("abc")]
    [InlineData("123")]
    [InlineData("aB 1?2,E   &`")]
    [InlineData(" ")]
    [InlineData("")]
    public void Given_new_message_When_get_message_Then_input_equal_message(string _message)
    {
      // Arrange
      var mockInputController = new Mock<IInput>();
      var subject = new Subject<string>();

      mockInputController.Setup(controller => controller.Input).Returns(subject);

      mockInputController.Setup(controller => controller.GetMessage(It.IsAny<string>()))
                         .Callback<string>(msg => subject.OnNext(msg));

      string receivedMessage = null;

      subject.Subscribe(msg => receivedMessage = msg);

      // Act
      mockInputController.Object.GetMessage(_message);

      // Assert
      Assert.Equal(_message, receivedMessage);
    }
  }
}
