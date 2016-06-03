using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameEngine.GameEngine;

namespace GameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new AdvancedEngine();
            engine.Run();
        }
    }
}
