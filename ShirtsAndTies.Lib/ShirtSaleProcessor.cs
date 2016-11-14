using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtsAndTies.Lib
{
    public class ShirtSaleProcessor : ISalesProcessor
    {
        private ISalesProcessor SalesProcessor;
        public ShirtSaleProcessor(ISalesProcessor salesprocessor)
        {
            this.SalesProcessor = salesprocessor;
        }
        public void Process(string input)
        {
            Debug.WriteLine("shirt");
        }
    }
}
