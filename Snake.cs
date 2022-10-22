using System.Collections.Generic;

namespace snake_game
{
    public class Snake
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();

        // obs: aspas simples delimita um char; 
        char key = 'w'; 
        char dir = 'u';

        public int x { get; set; }
        public int y { get; set; }

        List<Position> snakeBody;

        public Snake()
        {
            this.x = 24;
            this.y = 10;

            snakeBody = new List<Position>();
            snakeBody.Add(new Position(x, y));
        }

        public void drawSnake()
        {
            foreach (Position pos in snakeBody)
            {
                Console.SetCursorPosition(pos.x, pos.y);
                Console.Write("0");   
            }
        }

        public void Input()
        {
            if(Console.KeyAvailable)
            {   
                // KeyChar() => informa pressionamentos de teclas em tempo de execução;
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }

        public void direction()
        {
            // u = up | d = down
            // r = right | l = left
            if(key == 'w' && dir != 'd')
            {
                dir = 'u';
            } else if(key == 's' && dir != 'u')
            {
                dir = 'd';
            } else if(key == 'd' && dir != 'l')
            {
                dir = 'r';
            } else if (key == 'a' && dir != 'r')
            {
                dir = 'l';
            }

        }

        public void moveSnake()
        {
            if(dir == 'u')
            {
                y--;
            } else if(dir == 'd')
            {
                y++;
            } else if(dir == 'r')
            {
                x++;
            } else if(dir == 'l')
            {
                x--;
            }

            snakeBody.Add(new Position(x, y));
            snakeBody.RemoveAt(0);
            Thread.Sleep(80);
        }

        public void eat(Position food, Food f)
        {
            Position sn = snakeBody[snakeBody.Count - 1];

            if(sn.x == food.x && sn.y == food.y)
            {
                snakeBody.Add(new Position(x, y));
                f.foodNewLocation();
            }
        }

        public void isDead()
        {
            
        }
    }
}