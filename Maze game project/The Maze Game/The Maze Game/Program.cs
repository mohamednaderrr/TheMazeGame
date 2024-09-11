namespace The_Maze_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello To Maze Game!");

            //Console.WriteLine("Use KeyBoard Arrows To Move The Player");

            Maze maze=new Maze(40,20);//Construct New Maze
            while (true) 
            {
                maze.DrawMaze();
                maze.MovePlayer();
            }
          
        }
    }
}
