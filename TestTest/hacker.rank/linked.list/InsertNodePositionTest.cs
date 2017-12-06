using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teste;

namespace TestTest
{
    [TestClass]
    public class InsertNodePositionTest
    {
        [TestMethod]
        public void NullTest()
        {
            InsertNodePosition p = new Teste.InsertNodePosition();
            Assert.AreEqual(3, p.InsertNth(null, 3, 0).Data);
            
        }


        [TestMethod]
        public void DataTest() {
            InsertNodePosition p = new Teste.InsertNodePosition();
            Node n1 = new Node
            {
                Data = 3,
                Next = null
            };
            Assert.AreEqual(4, p.InsertNth(n1, 5, 1).Data);
        }
    }
}
