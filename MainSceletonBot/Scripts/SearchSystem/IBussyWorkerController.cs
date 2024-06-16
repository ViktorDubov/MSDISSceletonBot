using MainSceletonBot.Scripts.DataSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSceletonBot.Scripts.SearchSystem
{
  public interface IBussyWorkerController
  {
    List<Worker> Workers { get; }

    void AddCustomerTaskToWorker(CustomerTask _customerTask, Worker _worker);
    CustomerTask FinishCustomerTaskFromWorker(Worker _worker);
  }
}
