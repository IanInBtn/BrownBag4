using NUnit.Framework;

namespace TDD.BowlingGame.Test
{
    public class Tests
    {
        private BowlingGame BowlingGame { get; set; }

        [SetUp]
        public void Setup()
        {
            BowlingGame = new BowlingGame();
        }

        [Test]
        public void GutterGame()
        {
            Assert.IsTrue(BowlingGame.Score == 0);
        }
    }
}