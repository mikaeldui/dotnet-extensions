using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Text.Json.Tests
{
    [TestClass]
    public class DeserializeTests
    {
        [TestMethod]
        public void Deserialize()
        {
            var json = "{\"key1\": \"value1\", \"key2\": \"value2\"}";

            using var doc = JsonDocument.Parse(json);

            var dict = doc.Deserialize<Dictionary<string, string>>();

            Assert.AreEqual("key1", dict.Keys.First());
            Assert.AreEqual("value2", dict.Values.Last());
        }
    }
}
