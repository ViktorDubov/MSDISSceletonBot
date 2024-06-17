using MainSceletonBot.Scripts.DataSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
