using MainSceletonBot.Scripts.DataSystem.Model;

namespace MainSceletonBot.Scripts.SearchSystem
{
  public interface IBussyWorkerController
  {
    List<Worker> Workers { get; }

    void AddCustomerTaskToWorker(CustomerTask _customerTask, Worker _worker);
    CustomerTask FinishCustomerTaskFromWorker(Worker _worker);
  }
}
