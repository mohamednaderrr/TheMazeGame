using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Maze_Game
{
    public class Maze
    {
        private int _Width;
        private int _Height;
        private Player _Player;
        private IMazeObject[,] _MazeObjectsArray;//MultiDimatition Array

        public Maze(int width, int height)
        {
            _Width = width;
            _Height = height;
            _MazeObjectsArray= new IMazeObject[width, height];
            _Player = new Player()
            {
                //Object Inintazlior
                X = 1,
                Y = 1,
            };
            

        }

        public void DrawMaze()
        {
            Console.Clear();
            for (int y = 0; y < _Height; y++)
            {
                for (int x = 0; x < _Width; x++)
                {
                    //Outer Walls&Exit
                    if (x == 39 && y ==19 )
                    {
                        _MazeObjectsArray[x, y] = new EmptySpace();//Casting
                        Console.Write(_MazeObjectsArray[x, y].Icon);//انا عاوز اطبع الاوبكجيت بتاعه
                    }
                    else if (x == 0 || y==0 ||x==_Width - 1 || y==_Height - 1)
                    {
                        _MazeObjectsArray[x, y] = new Wall();//Casting

                        Console.Write(_MazeObjectsArray[x, y].Icon);//انا عاوز اطبع الاوبكجيت بتاعه
                    }
                    else if (x == _Player.X && y == _Player.Y)
                    {
                        Console.Write(_Player.Icon);
                    }
                    else if(x % 3 == 0 && y % 3 == 0)
                    {

                        _MazeObjectsArray[x, y] = new Wall();//Casting

                        Console.Write(_MazeObjectsArray[x, y].Icon);//انا عاوز اطبع الاوبكجيت بتاعه
                    }
                    else if (x % 5 == 0 && y % 5 == 0)
                    {

                        _MazeObjectsArray[x, y] = new Wall();//Casting

                        Console.Write(_MazeObjectsArray[x, y].Icon);//انا عاوز اطبع الاوبكجيت بتاعه
                    }

                    else //Empty Spaces
                    {
                        _MazeObjectsArray[x, y] = new EmptySpace();//Casting
                        Console.Write(_MazeObjectsArray[x, y].Icon);//انا عاوز اطبع الاوبكجيت بتاعه

                    }

                }

                Console.WriteLine();
            }
        }
        public void MovePlayer()
        {
         ConsoleKeyInfo userInput= Console.ReadKey();

         ConsoleKey key = userInput.Key;

            switch (key) 
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    UpdatePlayer(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    UpdatePlayer(1, 0);
                    break;

            }
        }

        private void UpdatePlayer(int dx,int dy) 
        { 
            int newX=_Player.X+dx;
            int newY = _Player.Y + dy;

            if (newX < _Width && newX>=0&& newY<_Height&&newY>=0 && _MazeObjectsArray[newX,newY].IsSolid ==false)
            {
                _Player.X = newX;
                _Player.Y = newY;
                DrawMaze();
            }


        }
    }
}
