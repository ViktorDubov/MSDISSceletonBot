using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSceletonBot.Scripts.DataSystem.Model
{
  public class Worker
  {
    public string ID { get; }
    public CustomerTask? TaskInWork { get; private set; }
    public bool IsBussy { get; private set; } = false;
    public Worker()
    {
      ID = IDSetter.GetWorkerID();
    }
    public void SetTaskInWork(CustomerTask _taskInWork)
    {
      TaskInWork = _taskInWork;
      IsBussy = true;
    }
    public void FinishTaskInWork()
    {
      TaskInWork = null;
      IsBussy = false;
    }
  }
}
