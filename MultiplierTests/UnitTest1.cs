namespace MultiplierTests
{
    public class Tests
    {
 

        [Test]
        public void MultiplTreeNumbers()
        {
          var actual = Sumator.Multiplier.multi(new int[] { 1, 2,3,3 });
            Assert.That(actual, Is.EqualTo(18)) ;
        }
    }
}