using System;
using System.Linq;
using snake_game_classes;

namespace snake_game {
    class Program
    {
        public static void Main(string[] args)
        {
            var canvas = new Canvas();
            var snake = new Snake();
            var food = new Food();

            // tirando visibilidade do cursor
            Console.CursorVisible = false;

            bool finished = false;
            while(!finished)
            {
                try{
                    canvas.drawCanvas();

                    Console.SetCursorPosition(canvas.Width-1, canvas.Height);
                    if(snake.score > 9) {
                        Console.Write($"{snake.score}");
                    } else{
                    Console.Write($"0{snake.score}");
                    }

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
                    
                    Console.Write("\nDeseja começar de novo? (S/N) : ");
                    char c = char.Parse(Console.ReadLine());

                    switch(c)
                    {
                        case 's':
                        case 'S': 
                            snake.x = 24; 
                            snake.y = 12;   
                            snake.score = 0;
                            snake.dir = 'p';
                            snake.key = 'p';
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