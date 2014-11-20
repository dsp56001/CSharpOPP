using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyAgain
{
    public interface IProduct
    {
        double Cost { get; set; }
        string Name { get; set; }
    }
}
