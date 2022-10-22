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
                    canvas.drawCanvas(90, 24);

                    Console.SetCursorPosition(canvas.Width, canvas.Height);
                    Console.Write($"{snake.score}");

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
                    
                    Console.Write("Começar de novo (S/N)");
                    char c = char.Parse(Console.ReadLine());

                    switch(c)
                    {
                        case 's':
                        case 'S': 
                            snake.x = 22; 
                            snake.y = 18;   
                            snake.score = 0;
                            snake.snakeBody.RemoveRange(0, snake.snakeBody.Count - 1);
                        break;    

                        case 'n':
                        case 'N':
                            finished = true;
                        break;

                    }
                }
            }
        }
    }
}