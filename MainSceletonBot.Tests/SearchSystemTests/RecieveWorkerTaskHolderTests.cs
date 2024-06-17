using MainSceletonBot.Scripts.DataSystem.Model;
using MainSceletonBot.Scripts.SearchSystem;
using Moq;

namespace MainSceletonBot.Tests.SearchSystemTests
{
  public class RecieveWorkerTaskHolderTests
  {
    [Fact]
    public async Task Given_customer_task_When_recieve_do_work_then_status_is_agree()
    {
      // Arrange
      var mockRecieveWorkerTaskHolder = new Mock<IRecieveWorkerTaskHolder>();
      var customerTask = new CustomerTask("Test Task");
      var cancellationToken = CancellationToken.None;

      mockRecieveWorkerTaskHolder
          .Setup(holder => holder.RecieveDoWorkAsync(customerTask, cancellationToken))
          .ReturnsAsync(RecieveDoWorkStatuses.Agree);

      // Act
      var status = await mockRecieveWorkerTaskHolder.Object.RecieveDoWorkAsync(customerTask, cancellationToken);

      // Assert
      Assert.Equal(RecieveDoWorkStatuses.Agree, status);
    }

    [Fact]
    public async Task Given_customer_task_When_recieve_do_work_then_status_is_refuse()
    {
      // Arrange
      var mockRecieveWorkerTaskHolder = new Mock<IRecieveWorkerTaskHolder>();
      var customerTask = new CustomerTask("Test Task");
      var cancellationToken = CancellationToken.None;

      mockRecieveWorkerTaskHolder
          .Setup(holder => holder.RecieveDoWorkAsync(customerTask, cancellationToken))
          .ReturnsAsync(RecieveDoWorkStatuses.Refuse);

      // Act
      var status = await mockRecieveWorkerTaskHolder.Object.RecieveDoWorkAsync(customerTask, cancellationToken);

      // Assert
      Assert.Equal(RecieveDoWorkStatuses.Refuse, status);
    }

    [Fact]
    public async Task Given_customer_task_When_recieve_do_work_then_status_is_wait()
    {
      // Arrange
      var mockRecieveWorkerTaskHolder = new Mock<IRecieveWorkerTaskHolder>();
      var customerTask = new CustomerTask("Test Task");
      var cancellationToken = CancellationToken.None;

      mockRecieveWorkerTaskHolder
          .Setup(holder => holder.RecieveDoWorkAsync(customerTask, cancellationToken))
          .ReturnsAsync(RecieveDoWorkStatuses.Wait);

      // Act
      var status = await mockRecieveWorkerTaskHolder.Object.RecieveDoWorkAsync(customerTask, cancellationToken);

      // Assert
      Assert.Equal(RecieveDoWorkStatuses.Wait, status);
    }
  }
}
