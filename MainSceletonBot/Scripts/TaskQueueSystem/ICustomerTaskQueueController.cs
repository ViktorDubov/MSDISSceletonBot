using MainSceletonBot.Scripts.DataSystem.Model;

namespace MainSceletonBot.Scripts.TaskQueueSystem
{
  public interface ICustomerTaskQueueController
  {
    CustomerTaskQueue QueueHolder { get; }
    void AddCustomerTaskToQueue(CustomerTask _customerTask);
  }
}
