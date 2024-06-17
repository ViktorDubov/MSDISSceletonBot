namespace MainSceletonBot.Scripts.DataSystem.Model
{
  public class Customer
  {
    public string ID { get; }
    public string Name { get; }
    public List<CustomerTask> CurrentTasks { get; private set; }

    public Customer(string _name)
    {
      CurrentTasks = new List<CustomerTask>();
      ID = IDSetter.GetCustomerID();
      Name = _name;
    }
  }
}
