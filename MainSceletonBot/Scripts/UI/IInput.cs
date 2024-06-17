using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace MainSceletonBot.Scripts.UI
{
  public interface IInput
  {
    Subject<string> Input { get; }
    void GetMessage(string _message);
  }
}
