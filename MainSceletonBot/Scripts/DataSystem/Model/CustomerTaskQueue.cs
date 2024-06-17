using System.Reactive.Subjects;

namespace MainSceletonBot.Scripts.DataSystem.Model
{
  public class CustomerTaskQueue
  {
    public Queue<CustomerTask> Queue { get; private set; }

    public Subject<CustomerTask> CustomerTaskFlow { get; private set; }

    public CustomerTaskQueue() 
    { 
      Queue = new Queue<CustomerTask>();
      CustomerTaskFlow = new Subject<CustomerTask>();
    }

    public void AddCustomerTask(CustomerTask customerTask)
    {
      Queue.Enqueue(customerTask);
      if(Queue.Count == 1 )
      { 
        CustomerTaskFlow.OnNext(Queue.Dequeue());
      }
    }

    public bool RecievePublishNextCustomerTask()
    {
      if(Queue.Count > 0 )
      {
        CustomerTaskFlow.OnNext(Queue.Dequeue());
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
