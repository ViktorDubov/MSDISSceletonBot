namespace MainSceletonBot.Scripts.DataSystem.Model
{
  public enum TaskStatuses
  {
    Send = 0,
    InQueue = 1,
    InSearch = 2,
    InWork = 3,
    Done = 4,
    Rejected = 5
  }
  public class CustomerTask
  {
    public string ID { get; }
    public string Annotation { get; }
    public DateTime SetTime { get; }
    public TaskStatuses CurrentStatus { get; set; }
    public CustomerTask(string _annotation)
    {
      ID = IDSetter.GetCustomerTaskID();
      Annotation = _annotation;
      SetTime = DateTime.Now;
      CurrentStatus = TaskStatuses.Send;
    }
  }
}
