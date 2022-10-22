using System;
using System.Linq;

namespace snake_game {
    class Program
    {
        public static void Main(string[] args)
        {
            var canvas = new Canvas();
            bool finished = false;

            while(!finished)
            {
                canvas.drawCanvas();
                Console.Read();
            }
        }
    }
}