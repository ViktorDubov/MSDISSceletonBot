namespace MainSceletonBot.Scripts.DataSystem.Model
{
  public class CustomerTaskQueue
  {
    public Queue<CustomerTask> Queue { get; private set; }

    public IObservable<CustomerTask>? QueueObservable { get; private set; }

    public CustomerTaskQueue() 
    { 
      Queue = new Queue<CustomerTask>();
    }

    public void AddCustomerTask(CustomerTask customerTask)
    {
      throw new NotImplementedException();
    }

    public bool RecievePublishNextCustomerTask()
    {
      throw new NotImplementedException();
    }
  }
}
