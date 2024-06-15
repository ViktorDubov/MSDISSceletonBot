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
    public List<CustomerTask> CurrentTasks { get; private set; }

    public Customer() 
    { 
      CurrentTasks = new List<CustomerTask>();
      ID = IDSetter.GetCustomerID();
    }
  }
}
