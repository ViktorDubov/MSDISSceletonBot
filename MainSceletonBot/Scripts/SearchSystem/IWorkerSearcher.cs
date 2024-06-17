using MainSceletonBot.Scripts.DataSystem.Model;

namespace MainSceletonBot.Scripts.SearchSystem
{
  public interface IWorkerSearcher
  {
    List<Worker> AllWorkers { get; }
    List<Worker> FreeWorkers { get; }

    IRecieveWorkerTaskHolder CurrentReciever {  get; }

    void SearchWorker(CustomerTask _customerTask);
  }
}
