using System.Collections.Generic;

namespace snake_game
{
    public class Snake
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'w'; 

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

            foreach (var item in snakeBody)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("⬛");   
            }
        }

        public void Input()
        {
            if(Console.KeyAvailable)
            {   
                // KeyChar() => informa pressionamentos de teclas em tempo de execução;
                key = keyInfo.KeyChar;
            }
        }
    }
}