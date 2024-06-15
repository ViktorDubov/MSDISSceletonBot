using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainSceletonBot.Scripts.DataSystem.Model;

namespace MainSceletonBot.Tests.ModelTests
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
      var queue = new CustomerTaskQueue();
      var task = new CustomerTask("Test Task");

      // Act
      queue.AddCustomerTask(task);

      // Assert
      Assert.Single(queue.Queue);
      Assert.Contains(task, queue.Queue);
    }

    [Fact]
    public void Given_customer_task_in_queue_When_receive_publish_next_task_Then_task_is_dequeued()
    {
      // Arrange
      var queue = new CustomerTaskQueue();
      var task1 = new CustomerTask("Test Task 1");
      var task2 = new CustomerTask("Test Task 2");
      queue.AddCustomerTask(task1);
      queue.AddCustomerTask(task2);

      // Act
      var result = queue.RecievePublishNextCustomerTask();

      // Assert
      Assert.True(result);
      Assert.Single(queue.Queue); // Только одна задача остается в очереди
      Assert.Equal(task2, queue.Queue.Peek()); // Проверка того, что следующая задача в очереди — это task2
    }

    [Fact]
    public void Given_empty_queue_When_receive_publish_next_task_Then_return_false()
    {
      // Arrange
      var queue = new CustomerTaskQueue();

      // Act
      var result = queue.RecievePublishNextCustomerTask();

      // Assert
      Assert.False(result);
    }
  }
}