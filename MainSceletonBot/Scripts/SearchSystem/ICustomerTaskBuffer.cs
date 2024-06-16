using MainSceletonBot.Scripts.DataSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
