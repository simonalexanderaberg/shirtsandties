using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtsAndTies.Lib
{
    public class TieSaleProcessor : ISalesProcessor
    {
          private ISalesProcessor SalesProcessor;
        public TieSaleProcessor(ISalesProcessor salesprocessor)
        {
            this.SalesProcessor = salesprocessor;
        }
        public void Process(string input)
        {
            Debug.WriteLine("tie");
        }
    }
}
