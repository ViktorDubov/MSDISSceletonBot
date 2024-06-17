using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainSceletonBot.Scripts.DataSystem.Model;
using MainSceletonBot.Scripts.SearchSystem;
using Moq;

namespace MainSceletonBot.Tests.SearchSystemTests
{
  public class BussyWorkerControllerTests
  {
    [Fact]
    public void Given_customer_task_and_worker_When_add_customer_task_to_worker_Then_worker_is_bussy()
    {
      // Arrange
      var mockBussyWorkerController = new Mock<IBussyWorkerController>();
      var worker = new Worker();
      var customerTask = new CustomerTask("Test Task");

      mockBussyWorkerController.Setup(controller => controller.Workers).Returns(new List<Worker> { worker });
      mockBussyWorkerController.Setup(controller => controller.AddCustomerTaskToWorker(customerTask, worker)).Callback((CustomerTask task, Worker w) =>
      {
        w.SetTaskInWork(task);
      });

      // Act
      mockBussyWorkerController.Object.AddCustomerTaskToWorker(customerTask, worker);

      // Assert
      Assert.True(worker.IsBussy);
      Assert.Equal(customerTask, worker.TaskInWork);
    }

    [Fact]
    public void Given_worker_with_task_When_finish_customer_task_from_worker_Then_worker_is_not_bussy()
    {
      // Arrange
      var mockBussyWorkerController = new Mock<IBussyWorkerController>();
      var worker = new Worker();
      var customerTask = new CustomerTask("Test Task");
      worker.SetTaskInWork(customerTask);

      mockBussyWorkerController.Setup(controller => controller.Workers).Returns(new List<Worker> { worker });
      mockBussyWorkerController.Setup(controller => controller.FinishCustomerTaskFromWorker(worker)).Returns(() =>
      {
        var finishedTask = worker.TaskInWork;
        worker.FinishTaskInWork();
        return finishedTask;
      });

      // Act
      var finishedTask = mockBussyWorkerController.Object.FinishCustomerTaskFromWorker(worker);

      // Assert
      Assert.False(worker.IsBussy);
      Assert.Null(worker.TaskInWork);
      Assert.Equal(customerTask, finishedTask);
    }
  }
}
