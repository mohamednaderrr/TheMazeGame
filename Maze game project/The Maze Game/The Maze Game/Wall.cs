using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Maze_Game
{
    internal class Wall : IMazeObject
    {
        public char Icon { get => '#'; }

        public bool IsSolid { get => true; }//عشان مش عاوزه تعدي 
    }
}
