using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSceletonBot.Scripts.CommandSystem
{
  public enum Commands
  {
    AddWorker,
    RemoveWorker,
    AddNewTask,
    GetTaskStatus,
    CancelTask
  }
  public interface ICommandHandler
  {
    bool TryParseMessageToCommandAndContext<T>(string _message, out T _tOut);
    void DoCommand<T>(CommandAndContextHolder<T> _holder);
  }
}
