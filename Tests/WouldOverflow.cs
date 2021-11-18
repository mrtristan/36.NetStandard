﻿namespace Base36Library.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class WouldOverflow
    {
        [Test]
        public void Would()
        {
            Assert.IsTrue(Base36.WouldOverflow("1Y2P0IJ32E8E8"));
            Assert.IsTrue(Base36.WouldOverflow("-1Y2P0IJ32E8E9"));
            Assert.IsTrue(Base36.WouldOverflow("SOMEWHATLONGSTRING"));
        }

        [Test]
        public void Wouldnt()
        {
            Assert.IsFalse(Base36.WouldOverflow("0"));
            Assert.IsFalse(Base36.WouldOverflow("A"));
            Assert.IsFalse(Base36.WouldOverflow("ABC"));
            Assert.IsFalse(Base36.WouldOverflow("SHORTSTRING"));
            Assert.IsFalse(Base36.WouldOverflow("1Y2P0IJ32E8E7"));
            Assert.IsFalse(Base36.WouldOverflow("-1Y2P0IJ32E8E8"));
        }
    }
}
