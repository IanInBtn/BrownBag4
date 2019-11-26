using NUnit.Framework;

namespace TDD.TicTacToe.Test
{
    public class Tests
    {
        private IGame _game;

        [SetUp]
        public void Setup()
        {
            var board = new Board();
            _game = new Game(board);
        }
    }
}