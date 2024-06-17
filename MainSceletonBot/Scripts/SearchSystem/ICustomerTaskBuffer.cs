using MainSceletonBot.Scripts.DataSystem.Model;
using System.Reactive.Subjects;

namespace MainSceletonBot.Scripts.SearchSystem
{
  public interface ICustomerTaskBuffer
  {
    Subject<bool> CanSearchNewWorker {  get; }//???
    bool IsSearchSystemBussy { get; }//???

    Subject<CustomerTask> NewCustomerTaskToSearch { get; }

    void RecieveNewSearch();
  }
}
