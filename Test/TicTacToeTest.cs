using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using spil;

namespace Test
{
    [TestClass]
    public class TicTacToeTest {
        [TestMethod]
        public void TicTacToeCanStart()
        {
            TicTacToe ticTacToe = new TicTacToe();
            Assert.AreNotEqual(ticTacToe, null);
        }
        [TestMethod]
        public void TicTacToeCanPlace()
        {
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.Place(1, 1);
            char[,] reference = new char[3, 3]
            {
                {' ',' ',' '},
                {' ','X',' '},
                {' ',' ',' '},
            };
            CollectionAssert.AreEqual(reference, ticTacToe.GameBoard);
        }
        [TestMethod]
        public void TicTacToeCanNotReplace()
        {
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.Place(1, 1);
            ticTacToe.Place(1, 1);
            char[,] reference = new char[3, 3]
            {
                {' ',' ',' '},
                {' ','X',' '},
                {' ',' ',' '},
            };
            CollectionAssert.AreEqual(reference, ticTacToe.GameBoard);
        }
        [TestMethod]
        public void TicTacToeNoMoreThan3()
        {
            TicTacToeVariant ticTacToe = new TicTacToeVariant();
            char[,] check =
            {
                { 'X',' ',' '},
                { ' ',' ','X'},
                { 'X',' ',' '},
            };
            char[,] reference =
            {
                { 'X',' ',' '},
                { ' ',' ','X'},
                { 'X',' ',' '},
            };
            ticTacToe.GameBoard = check;
            ticTacToe.Place(1, 1);
            CollectionAssert.AreEqual(reference, ticTacToe.GameBoard);
        }
        [TestMethod]
        public void CanNotMoveOpponent()
        {
            TicTacToeVariant ticTacToe = new TicTacToeVariant();
            ticTacToe.Place(1, 1);
            ticTacToe.Move(1, 1, 2, 2);
            char[,] reference =
            {
                {' ',' ',' '},
                {' ','X',' '},
                {' ',' ',' '},
            };
            CollectionAssert.AreEqual(reference, ticTacToe.GameBoard);
        }
        [TestMethod]
        public void CanMove()
        {
            TicTacToeVariant ticTacToe = new TicTacToeVariant();
            char[,] check =
            {
                { 'X',' ',' '},
                { ' ',' ','X'},
                { 'X',' ',' '},
            };
            char[,] reference =
            {
                { ' ',' ',' '},
                { ' ','X','X'},
                { 'X',' ',' '},
            };
            ticTacToe.GameBoard = check;
            ticTacToe.Move(0, 0, 1, 1);
            CollectionAssert.AreEqual(reference, ticTacToe.GameBoard);
        }
        [TestClass]
        public class GameWinnerServiceTests
        {
            private char[,] GameBoard;

            [TestMethod]
            public void NeitherPlayerIsWinner()
            {
                GameBoard = new char[3, 3]
            {
                    {' ', ' ', ' '},
                    {' ', ' ', ' '},
                    {' ', ' ', ' '}
                };
                Assert.AreEqual(' ', TicTacToe.Validate(GameBoard));
            }

            [TestMethod]
            public void PlayerWithAllSpacesInTopRowIsWinner()
            {
                GameBoard = new char[3, 3] 
                {
                {'X', 'X', 'X'},
                {' ', ' ', ' '},
                {' ', ' ', ' '}
            };

                Assert.AreEqual('X', TicTacToe.Validate(GameBoard));
            }

            [TestMethod]
            public void playerwithallspacesinsecondrowiswinner()
            {
                GameBoard = new char[3, 3]
            {
                    {' ', ' ', ' '},
                    {'X', 'X', 'X'},
                    {' ', ' ', ' '}
                };

                Assert.AreEqual('X', TicTacToe.Validate(GameBoard));
            }
            [TestMethod]
            public void PlayerWithAllSpacesInThrirdRowIsWinner()
            {
                GameBoard = new char[3, 3]
            {
                    {' ', ' ', ' '},
                    {' ', ' ', ' '},
                    {'X', 'X', 'X'}
                };

                Assert.AreEqual('X', TicTacToe.Validate(GameBoard));
            }


        }
        }
    }

