namespace MultiplierTests
{
    public class Tests
    {
 

        [Test]
        public void MultiplTreeNumbers()
        {
          var actual = Sumator.Multiplier.multi(new int[] { 1, 2,3,3 });
            Assert.AreEqual(actual, 19) ;
        }
    }
}