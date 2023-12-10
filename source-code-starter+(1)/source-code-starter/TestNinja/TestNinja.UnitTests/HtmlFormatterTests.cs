using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("abc");

            //Specific
            //Assert.That(result,Is.EqualTo("<strong>aBc</strong>").IgnoreCase);

            //More General
            //IngnoreCase 可以忽略大小寫
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abC").IgnoreCase);
        }
    }
}
