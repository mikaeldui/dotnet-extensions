using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Linq.Tests
{
    [TestClass]
    public class EnumerableTests
    {
        [TestMethod]
        public void SkipLastTest()
        {
            var enumerable = Enumerable.Range(0, 10);
            Assert.AreEqual(8, enumerable.SkipLast(2).Count());
        }
    }
}
