using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtsAndTies.Lib
{
   public class ShirtsAndTiesFacade
    {
          private ISalesProcessor SalesProcessor;
          public ShirtsAndTiesFacade(ISalesProcessor salesprocessor)
       {
           this.SalesProcessor = salesprocessor;
       }
       public void Get(string input)
       {
           SalesProcessor.Process(input);
       }
    }
}
