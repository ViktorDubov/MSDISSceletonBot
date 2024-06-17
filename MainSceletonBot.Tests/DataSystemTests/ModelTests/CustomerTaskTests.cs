using MainSceletonBot.Scripts.DataSystem.Model;

namespace MainSceletonBot.Tests.DataSystemTests.ModelTests
{
  public class CustomerTaskTests
  {
    [Fact]
    public void Given_few_new_customer_task_When_initialized_Then_each_has_unique_ID()
    {
      //Act
      var customerTask1 = new CustomerTask("Test Task");
      var customerTask2 = new CustomerTask("Test Task");

      //Assert
      Assert.NotEqual(customerTask1.ID, customerTask2.ID);
    }

    [Theory]
    [InlineData("abc")]
    [InlineData("123")]
    [InlineData("aB 1?2,E   &`")]
    [InlineData(" ")]
    [InlineData("")]
    public void Given_new_customer_task_When_initialized_Then_has_correct_annotation(string _annotation)
    {
      //Arrange
      string annotation = _annotation;

      //Act
      var customerTask = new CustomerTask(annotation);

      //Assert
      Assert.Equal(_annotation, customerTask.Annotation);
    }
  }
}
