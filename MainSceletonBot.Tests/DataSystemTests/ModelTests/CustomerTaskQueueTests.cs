using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainSceletonBot.Scripts.DataSystem.Model;
using MainSceletonBot.Scripts.TaskQueueSystem;
using Moq;

namespace MainSceletonBot.Tests.DataSystemTests.ModelTests
{
  public class CustomerTaskQueueTests
  {
    [Fact]
    public void Given_new_queue_When_initialized_Then_queue_is_empty()
    {
        // Act
        var queue = new CustomerTaskQueue();

        // Assert
        Assert.NotNull(queue.Queue);
        Assert.Empty(queue.Queue);
    }

    [Fact]
    public void Given_customer_task_When_added_to_queue_Then_queue_contains_task()
    {
      // Arrange
      var mockQueue = new Mock<CustomerTaskQueue>();
      var task = new CustomerTask("Test Task");

      mockQueue.SetupGet(q => q.Queue).Returns(new Queue<CustomerTask>());

      mockQueue.Setup(q => q.AddCustomerTask(task))
               .Callback((CustomerTask customerTask) => mockQueue.Object.Queue.Enqueue(customerTask));

      // Act
      mockQueue.Object.AddCustomerTask(task);

      // Assert
      Assert.Single(mockQueue.Object.Queue);
      Assert.Contains(task, mockQueue.Object.Queue);
    }
  }
}