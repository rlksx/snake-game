using System;
using System.Linq;

namespace snake_game {
    class Program
    {
        public static void Main(string[] args)
        {
            var canvas = new Canvas();
            var snake = new Snake();
            var food = new Food();


            bool finished = false;
            while(!finished)
            {
                canvas.drawCanvas();
                snake.Input();
                food.drawFood();
                snake.drawSnake();
                snake.direction();
                snake.moveSnake();
                // Console.Read();
            }
        }
    }
}