using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSceletonBot.Scripts.UI
{
  public interface IInput
  {
    IObservable<string> Input { get; }
    void GetMessage(string _message);
  }
}
