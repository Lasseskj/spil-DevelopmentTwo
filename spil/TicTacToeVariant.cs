using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class TicTacToeVariant : TicTacToe, ITicTacToe
    {
        char player;
        public TicTacToeVariant()
        {
      
        }
        private void checkPlayer()
        {
            if (currentPlayer)
            {
                player = 'X';
            }
            else
            {
                player = 'Y';
            }
        }
        public bool Move(int fromX, int fromY, int toX, int toY)
        {
            checkPlayer();
            if (GameBoard[fromX, fromY] == player && GameBoard[toX,toY] == ' ')
            { 
                GameBoard[fromX, fromY] = ' ';
                GameBoard[toX, toY] = player;
                return true;
            }
            return false;
        }
        public override bool Place(int X,int Y)
        {
            checkPlayer();
            if (playerCount() < 3 && GameBoard[X,Y] == ' ')
            {
                GameBoard[X, Y] = player;
                currentPlayer = !currentPlayer;
                return true;
            }
            else
                return false;
        }
        private int playerCount()
        {
            int count = 0;
            foreach (char ocurrences in GameBoard)
            {
                if (ocurrences == player)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
