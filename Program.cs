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
                try{
                    canvas.drawCanvas();
                    snake.Input();
                    food.drawFood();
                    snake.drawSnake();
                    snake.direction();
                    snake.moveSnake();
                    snake.eat(food.foodLocation(), food);
                    snake.hitWall(canvas);
                    snake.isDead();
                } catch(SnakeException e) {
                    Console.Clear();
                    Console.Write(e.Message);
                    finished = true;
                }
            }
        }
    }
}