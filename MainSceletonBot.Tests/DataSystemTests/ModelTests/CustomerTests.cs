using System.Xml;
using MainSceletonBot.Scripts.DataSystem.Model;

namespace MainSceletonBot.Tests.DataSystemTests.ModelTests
{
  public class CustomerTests
  {
    [Fact]
    public void Given_few_new_customer_When_initialized_Then_each_has_unique_ID()
    {
      // Act
      var customer1 = new Customer();
      var customer2 = new Customer();

      // Assert
      Assert.NotEqual(customer1.ID, customer2.ID);
    }

    [Fact]
    public void Given_new_customer_When_initialized_Then_CurrentTasks_is_empty()
    {
      // Act
      var customer = new Customer();

      // Assert
      Assert.NotNull(customer.CurrentTasks);
      Assert.Empty(customer.CurrentTasks);
    }
  }
}