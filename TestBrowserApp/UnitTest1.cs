using System;
using NUnit.Framework;
using NSubstitute;

using BrowserFactory;

namespace TestBrowserApp
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Mock config with NSubstitute
            var substituteFactory = Substitute.For<IFactoryBrowser>();
            substituteFactory.createBrowser<Google>().Returns(new Google());

            var newBrowser = substituteFactory.createBrowser<Google>();
            Assert.AreEqual(typeof(Google), newBrowser.GetType());
        }
    }
}