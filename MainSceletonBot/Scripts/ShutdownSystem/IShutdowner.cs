using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSceletonBot.Scripts.ShutdownSystem
{
  public interface IShutdowner
  {
    Task ShutdownAsync(CancellationToken _cancellationToken);
  }
}
