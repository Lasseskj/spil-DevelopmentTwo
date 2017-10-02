using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    interface ITicTacToe
    {
        bool Place(int x, int y);
        string GetGameBoardView();
    }
}
