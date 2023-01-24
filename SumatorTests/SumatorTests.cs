using NUnit.Framework;
using System.Net.WebSockets;

namespace SumatorTests
{
    public class SumatorTests
    {

        [Test]
        public void SumTwoNumbers()
        {
            var nums = new[] { 1, 2 };
            var actual = Sumator.Sumator.Sum(nums);
            var expected = 3;
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void SumThreeNumbers()
        {
            var nums = new[] { 5, 6, 7, 8, };
            var actual = Sumator.Sumator.Sum(nums);
            var expected = 26;
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void ShortSyntax()
        {
            var result = Sumator.Sumator.Sum(new int[] { 1, 2 });
            Assert.AreEqual(result,3);
        }
    }
} aaaaaaaaaaaaaaaaaaaaa