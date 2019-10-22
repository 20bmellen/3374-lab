using Microsoft.VisualStudio.TestTools.UnitTesting;
using tttClassCore;

namespace tttClassTest
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestBoardFields()
        {
            tttClass testBoard = new tttClass();

            int result = testBoard.createBoard();
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestCP1()
        {
            tttClass testBoard = new tttClass();
            testBoard.cPlayer = testBoard.play1;
            char result = testBoard.currentPlayer();
            Assert.AreEqual('X', result);
        }

        [TestMethod]
        public void TestCP2()
        {
            tttClass testBoard = new tttClass();
            testBoard.cPlayer = testBoard.play1;
            testBoard.changePlayer();
            char result = testBoard.currentPlayer();
            Assert.AreEqual('O', result);
        }

        [TestMethod]
        public void TestCP1Place()
        {
            tttClass testBoard = new tttClass();
            testBoard.cPlayer = testBoard.play1;
            testBoard.makeMove(1);
            char result = testBoard.playBoard[0];
            Assert.AreEqual('X', result);


        }

        [TestMethod]
        public void TestCP2Place()
        {
            tttClass testBoard = new tttClass();
            testBoard.cPlayer = testBoard.play2;
            testBoard.makeMove(1);
            char result = testBoard.playBoard[0];
            Assert.AreEqual('O', result);
        }

        [TestMethod]
        public void freeSpot()
        {
            tttClass testBoard = new tttClass();
            bool result = testBoard.spaceInUse(1);
            Assert.AreEqual(true, result);
        }
    }
}
