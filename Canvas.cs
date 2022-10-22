namespace snake_game
{
    public class Canvas
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Canvas()
        {
            this.Width = 90;
            this.Height = 24;

            // tirando visibilidade do cursor
            Console.CursorVisible = false;
        }

        public void drawCanvas()
        {
            Console.Clear();

            // linha vertical 1
            Console.Write("+ ");
            for (int i = 0; i < Width - 2; i++)
            {
                Console.Write("=");
            }
            Console.Write(" +\n");

            // linhas horizontais
            for (int i = 0; i < Height; i++)
            {
                Console.Write("|");
                for (int x = 0; x < Width; x++)
                {
                    Console.Write(" ");
                }
                Console.Write("|\n");
            }

            // linha vertical 2
            Console.Write("+ ");
            for (int i = 0; i < Width - 2 ; i++)
            {
                Console.Write("=");
            }
            Console.Write(" +");

            this.drawHeaderCanvas();
        }

        public void drawHeaderCanvas()
        {
            // criando header
            Console.SetCursorPosition(0, 4);

            Console.Write("+ ");
            for (int i = 0; i < Width - 2; i++)
                Console.Write("=");

            Console.Write(" +");

            // inserindo titulo no header
            string text = "Snake Game by @rlksx";

            Console.SetCursorPosition(Width/2 - text.Length/2, 2);
            Console.Write(text);
        }
    }
}