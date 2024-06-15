using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
