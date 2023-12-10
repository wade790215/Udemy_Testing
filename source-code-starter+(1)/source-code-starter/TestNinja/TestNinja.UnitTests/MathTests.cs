using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        //(X)不要將Math當共用作參數儲存，保持物件乾淨
        //改用SetUp來重複初始化物件
        private Math _math; 

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        //[Ignore("因為我們想要測試的是Add方法，所以這個測試方法不需要")]
        public void Add_WhenCalled_ReturnTheSumOfArgfuments()
        {
            var result = _math.Add(1, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument(int a,int b,int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
