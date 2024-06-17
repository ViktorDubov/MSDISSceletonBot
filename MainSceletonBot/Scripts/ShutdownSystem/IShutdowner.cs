namespace MainSceletonBot.Scripts.ShutdownSystem
{
  public interface IShutdowner
  {
    Task ShutdownAsync(CancellationToken _cancellationToken);
  }
}
