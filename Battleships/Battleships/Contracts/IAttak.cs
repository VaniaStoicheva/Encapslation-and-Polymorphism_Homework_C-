using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleships.Ships;

namespace Battleships.Contracts
{
    interface IAttak
    {
        string Attak(Ship target);
    }
}
