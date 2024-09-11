using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Maze_Game
{
    public interface IMazeObject
    {
        char Icon { get;  }//The Shape Of The Maze Object  

        bool IsSolid { get;  }//Movemnt Block
    }
}
