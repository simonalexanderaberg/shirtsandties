using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShirtsAndTies.Lib;

namespace ShirtsAndTies.Tests
{
    [TestClass]
    public class Ties
    {
        [TestMethod]
        public void Test_TieSalesProcessor()
        {
            SaleProcessorFactory factory = new SaleProcessorFactory();
            ISalesProcessor salesprocessor = factory.CreateSaleProcessor(ProductTypeEnum.PTEnum.Tie);
            ShirtsAndTiesFacade facade = new ShirtsAndTiesFacade(salesprocessor);
            facade.Get("striped");
            salesprocessor.Process("striped");
            Assert.IsNotNull(salesprocessor);
            Assert.IsNotNull(facade);
        }
    }
}
