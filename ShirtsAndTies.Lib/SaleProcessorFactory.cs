using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtsAndTies.Lib
{
    public class SaleProcessorFactory
    {
        private ISalesProcessor salesprocessor;
        public ISalesProcessor CreateSaleProcessor(ProductTypeEnum.PTEnum productType)
        {
            if (productType == ProductTypeEnum.PTEnum.Tie)
                return new TieSaleProcessor(salesprocessor);
            else
                return new ShirtSaleProcessor(salesprocessor);
        }
    }
}
