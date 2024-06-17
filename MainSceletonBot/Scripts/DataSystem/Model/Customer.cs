using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public void AddCustomerTask(CustomerTask task)
    {
      CurrentTasks.Add(task);
    }
    public bool TryDeleteCustomerTask(CustomerTask task)
    { 
      if (CurrentTasks.Contains(task))
      {
        CurrentTasks.Remove(task);
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
