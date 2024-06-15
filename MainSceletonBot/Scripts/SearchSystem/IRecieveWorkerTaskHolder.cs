using MainSceletonBot.Scripts.DataSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSceletonBot.Scripts.SearchSystem
{
  public enum RecieveDoWorkStatuses
  {
    Agree = 0,
    Refuse = 1,
    Wait = 2
  }
  public interface IRecieveWorkerTaskHolder
  {
    Task<RecieveDoWorkStatuses> RecieveDoWorkAsync(CustomerTask _customerTask, CancellationToken _cancellationToken);
  }
}
