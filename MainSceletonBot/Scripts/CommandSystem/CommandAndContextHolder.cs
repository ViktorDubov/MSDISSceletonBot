using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSceletonBot.Scripts.CommandSystem
{
  public abstract class CommandAndContextHolder<T>
  {
    public Commands CommandForBot { get; }
    public T? Context { get; }
  }
}
