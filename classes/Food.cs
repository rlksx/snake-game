namespace snake_game_classes
{
    public class Food
    {
        public Position foodPosition = new Position();

        Random rnd = new Random();
        Canvas canvas = new Canvas();

        public Food()
        {
            this.foodPosition.x = rnd.Next(5, canvas.Width - 2);
            this.foodPosition.y = rnd.Next(5, canvas.Height);
        }

        public void drawFood()
        {
            Console.SetCursorPosition(foodPosition.x, foodPosition.y);
            Console.Write("%");
        }

        public Position foodLocation() => foodPosition;

        public void foodNewLocation()
        {
            this.foodPosition.x = rnd.Next(5, canvas.Width - 2);
            this.foodPosition.y = rnd.Next(5, canvas.Height);
        }
    }
}