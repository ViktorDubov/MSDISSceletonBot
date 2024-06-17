using MainSceletonBot.Scripts.DataSystem.Model;

namespace MainSceletonBot.Scripts.SearchSystem
{
  public interface ICustomerTaskBuffer
  {
    IObservable<bool> CanSearchNewWorker {  get; }//???
    bool IsSearchSystemBussy { get; }//???

    IObservable<CustomerTask> NewCustomerTaskToSearch { get; }

    void RecieveNewSearch();
  }
}
