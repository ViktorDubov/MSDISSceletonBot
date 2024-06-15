using MainSceletonBot.Scripts.DataSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
