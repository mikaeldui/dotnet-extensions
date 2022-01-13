using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Extensions.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void LastDigits()
        {
            int digits = 12345;
            string @string = "asdfadsfgsdgf" + digits;
            var result = @string.LastDigits();

           Assert.AreEqual(digits, result);
        }

        [TestMethod]
        public void Between()
        {
            string @string = "/summoner?summoner=EngIishman&region=EUW";
            var result = @string.Between("summoner=", "&region");

            Assert.AreEqual("EngIishman", result);
        }
    }
}
