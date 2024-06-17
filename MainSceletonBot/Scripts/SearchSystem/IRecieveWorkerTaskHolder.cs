using MainSceletonBot.Scripts.DataSystem.Model;

namespace MainSceletonBot.Scripts.SearchSystem
{
  public enum RecieveDoWorkStatuses
  {
    Agree = 0,
    Refuse = 1,
    Wait = 2
  }
  public interface IRecieveWorkerTaskHolder
  {
    Task<RecieveDoWorkStatuses> RecieveDoWorkAsync(CustomerTask _customerTask, CancellationToken _cancellationToken);
  }
}
