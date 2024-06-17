namespace MainSceletonBot.Scripts.CommandSystem
{
  public abstract class CommandAndContextHolder<T>
  {
    public Commands CommandForBot { get; }
    public T? Context { get; }
  }
}
