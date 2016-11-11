using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShirtsAndTies.Lib;

namespace ShirtsAndTies.Tests
{
    [TestClass]
    public class Shirts
    {
        [TestMethod]
        public void Test_ShirtSalesProcessor()
        {
            SaleProcessorFactory factory = new SaleProcessorFactory();
            ISalesProcessor salesprocessor = factory.CreateSaleProcessor(ProductTypeEnum.PTEnum.Shirt);
            ShirtsAndTiesFacade facade = new ShirtsAndTiesFacade(salesprocessor);
            facade.Get("i love ny");
            salesprocessor.Process("i love ny");
            Assert.IsNotNull(salesprocessor);
            Assert.IsNotNull(facade);
        }
    }
}
