using System;
using System.Linq;

namespace snake_game {
    class Program
    {
        public static void Main(string[] args)
        {
            var canvas = new Canvas();
            var snake = new Snake();


            bool finished = false;
            while(!finished)
            {
                canvas.drawCanvas();
                snake.Input();
                snake.drawSnake();
                snake.direction();
                snake.moveSnake();
                // Console.Read();
            }
        }
    }
}