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
        public int score { get; set; }

        public List<Position> snakeBody {get; set;}

        public Snake()
        {
            this.x = 24;
            this.y = 18;
            this.score = 0;

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
            if(dir == 'l' || dir == 'r')
            {
                Thread.Sleep(80);
            } else {
                Thread.Sleep(120);
            }
        }

        public void eat(Position food, Food f)
        {   
            // posição da cbç da cobra;
            Position head = snakeBody[snakeBody.Count - 1];

            if(head.x == food.x && head.y == food.y)
            {
                snakeBody.Add(new Position(x, y));
                f.foodNewLocation();
                score ++;
            }
        }

        public void isDead()
        {
            // posição da cbç da cobra;
            Position head = snakeBody[snakeBody.Count - 1];

            for (int i = 0; i < snakeBody.Count - 2; i++)
            {
                Position sb = snakeBody[i];
                if (head.x == sb.x && head.y == sb.y)
                {
                    throw new SnakeException("Você se enrolou!");
                }
            }
        }

        public void hitWall(Canvas canvas)
        {
            // cbç da cobra dnv
            Position head = snakeBody[snakeBody.Count - 1];

            if(head.x >= canvas.Width || head.x <= 0 || head.y >= canvas.Height || head.y <= 0)
            {
                throw new SnakeException("Você foi longe de mais!");
            }
        }
    }
}