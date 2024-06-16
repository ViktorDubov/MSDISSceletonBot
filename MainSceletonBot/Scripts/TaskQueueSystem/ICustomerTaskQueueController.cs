using MainSceletonBot.Scripts.DataSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSceletonBot.Scripts.TaskQueueSystem
{
  public interface ICustomerTaskQueueController
  {
    CustomerTaskQueue QueueHolder { get; }
    void AddCustomerTaskToQueue(CustomerTask _customerTask);
  }
}
