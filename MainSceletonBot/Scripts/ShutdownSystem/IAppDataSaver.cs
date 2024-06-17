namespace MainSceletonBot.Scripts.ShutdownSystem
{
  public interface IAppDataSaver
  {
    Task SaveAppDataAsync(CancellationToken _cancellationToken);
  }
}
