using MainSceletonBot.Scripts.DataSystem.Model;
using MainSceletonBot.Scripts.SearchSystem;
using Moq;

namespace MainSceletonBot.Tests.SearchSystemTests
{
  public class WorkerSearcherTests
  {
    [Fact]
    public void Given_worker_searcher_When_get_all_workers_Then_returns_all_workers()
    {
      // Arrange
      var mockWorkerSearcher = new Mock<IWorkerSearcher>();
      var workers = new List<Worker> { new Worker(), new Worker() };

      mockWorkerSearcher.Setup(searcher => searcher.AllWorkers).Returns(workers);

      // Act
      var result = mockWorkerSearcher.Object.AllWorkers;

      // Assert
      Assert.Equal(workers, result);
    }

    [Fact]
    public void Given_worker_searcher_When_get_free_workers_Then_returns_free_workers()
    {
      // Arrange
      var mockWorkerSearcher = new Mock<IWorkerSearcher>();
      var workers = new List<Worker> { new Worker(), new Worker() };
      var freeWorkers = workers.Where(worker => !worker.IsBussy).ToList();

      mockWorkerSearcher.Setup(searcher => searcher.FreeWorkers).Returns(freeWorkers);

      // Act
      var result = mockWorkerSearcher.Object.FreeWorkers;

      // Assert
      Assert.Equal(freeWorkers, result);
    }

    [Fact]
    public void Given_worker_searcher_When_get_current_reciever_Then_returns_correct_reciever()
    {
      // Arrange
      var mockWorkerSearcher = new Mock<IWorkerSearcher>();
      var mockRecieveWorkerTaskHolder = new Mock<IRecieveWorkerTaskHolder>();

      mockWorkerSearcher.Setup(searcher => searcher.CurrentReciever).Returns(mockRecieveWorkerTaskHolder.Object);

      // Act
      var result = mockWorkerSearcher.Object.CurrentReciever;

      // Assert
      Assert.Equal(mockRecieveWorkerTaskHolder.Object, result);
    }

    [Fact]
    public void Given_customer_task_When_search_worker_Then_search_worker_is_called()
    {
      // Arrange
      var mockWorkerSearcher = new Mock<IWorkerSearcher>();
      var customerTask = new CustomerTask("Test Task");

      // Act
      mockWorkerSearcher.Object.SearchWorker(customerTask);

      // Assert
      mockWorkerSearcher.Verify(searcher => searcher.SearchWorker(customerTask), Times.Once);
    }
  }
}
