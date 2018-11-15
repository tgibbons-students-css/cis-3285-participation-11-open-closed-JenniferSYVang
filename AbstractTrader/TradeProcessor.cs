using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTrader
{
    public interface ITradeProcessor
    {
        // removed all other methods into the child classes, making this the only one here
        void ProcessTrades(Stream stream);
    }
}
