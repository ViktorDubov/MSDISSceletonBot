namespace MainSceletonBot.Scripts.UI
{
  public interface IInput
  {
    IObservable<string> Input { get; }
    void GetMessage(string _message);
  }
}
