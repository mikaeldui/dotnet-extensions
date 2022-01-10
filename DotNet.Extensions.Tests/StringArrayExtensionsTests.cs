using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNet.Extensions.Tests
{
    [TestClass]
    public class StringArrayExtensionsTests
    {
        [TestMethod]
        public void ReplaceSingleValue()
        {
            string[] original = { "asd", "qwe", "zxc", "rty" };

            string replace = "qwe";
            string with = "123";

            original.Replace(replace, with);

            Assert.AreEqual(with, original[1]);
        }

        [TestMethod]
        public void ReplaceSingleRepeatedValue()
        {
            string[] original = { "asd", "qwe", "zxc", "qwe", "qwe", "rty" };

            string replace = "qwe";
            string with = "123";

            original.Replace(replace, with);

            Assert.AreEqual(with, original[1]);
            Assert.AreEqual(with, original[3]);
            Assert.AreEqual(with, original[4]);
        }
    }
}