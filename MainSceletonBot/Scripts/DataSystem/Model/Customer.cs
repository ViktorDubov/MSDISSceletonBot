namespace MainSceletonBot.Scripts.DataSystem.Model
{
  public class Customer
  {
    public string ID { get; }
    public List<CustomerTask> CurrentTasks { get; private set; }

    public Customer() 
    { 
      CurrentTasks = new List<CustomerTask>();
      ID = IDSetter.GetCustomerID();
    }
  }
}
