using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSceletonBot.Scripts.DataSystem.Model
{
  public static class IDSetter//fake, add normal guid in future
  {
    static uint s_CustomerCounter = 0;
    static uint s_CustomerTaskCounter = 0;
    static uint s_WorkerCounter = 0;

    public static void RestoreIDSetter()
    {
      throw new NotImplementedException("Needed realization for IDataBaseProxy");
    }
    public static string GetCustomerID()
    {
      s_CustomerCounter++;
      return s_CustomerCounter.ToString();
    }
    public static string GetCustomerTaskID()
    {
      s_CustomerTaskCounter++;
      return s_CustomerTaskCounter.ToString();
    }
    public static string GetWorkerID()
    {
      s_WorkerCounter++;
      return s_WorkerCounter.ToString();
    }
  }
}
