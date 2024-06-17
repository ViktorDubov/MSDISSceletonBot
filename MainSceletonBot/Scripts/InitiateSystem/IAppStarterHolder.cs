namespace MainSceletonBot.Scripts.InitiateSystem
{
  public interface IAppStarterHolder
  {
    IAppStarter AppStarter { get; }
    IAppEarlyDataChecker AppEarlyDataChecker { get; }
    IAppInitiator AppInitiator { get; }
    IAppRestorer AppRestorer { get; }
  }
}
