using MainSceletonBot.Scripts.DataSystem.Model;
using MainSceletonBot.Scripts.TaskQueueSystem;
using Moq;

namespace MainSceletonBot.Tests.TaskQueueSystemTests
{
  public class CustomerTaskQueueControllerTests
  {
    [Fact]
    public void Given_customer_task_When_add_customer_task_to_queue_Then_queue_contains_task()
    {
      // Arrange
      var mockQueueController = new Mock<ICustomerTaskQueueController>();
      var queue = new CustomerTaskQueue();
      var customerTask = new CustomerTask("Test Task");

      mockQueueController.Setup(controller => controller.QueueHolder).Returns(queue);
      mockQueueController.Setup(controller => controller.AddCustomerTaskToQueue(It.IsAny<CustomerTask>()))
                         .Callback<CustomerTask>(task => queue.Queue.Enqueue(task));

      // Act
      mockQueueController.Object.AddCustomerTaskToQueue(customerTask);

      // Assert
      Assert.Single(queue.Queue);
      Assert.Contains(customerTask, queue.Queue);
    }
  }
}
