using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameEngine.Interfaces
{
    public interface ITimeoutable
    {
        int Timeout { get; set; }

        int Countdown { get; set; }

        bool HasTimedOut { get; set; }
    }
}
