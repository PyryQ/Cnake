using System;
using System.Web;

namespace Cnake
{
    public class Game
    {
        public int Score { get; set; }
        public int[] Snake { get; set; }
        public int[] Apple { get; set; }
        public string Direction { get; set; }
        public int Speed { get; set; }
        public bool AppleDrawn { get; set; }

        public Game()
        {
            Score = 0;
            Snake = new int[] { 250, 250 };
            Apple = new int[] { 0, 0 };
            Direction = "right";
            Speed = 0;
            AppleDrawn = false;
        }

        public void DrawApple(int x, int y)
        {
            // Implementation to draw the apple
        }

        public void DrawSnake()
        {
            // Implementation to draw the snake
        }

        public void SpawnApple()
        {
            // Implementation to generate and spawn the apple
        }

        public void MoveSnake()
        {
            // Implementation to move the snake
        }

        public void SnakeEatsApple(int[] head, int[] apple)
        {
            // Implementation to handle when the snake eats the apple
        }

        public void StartGame()
        {
            // Implementation to start the game
        }

        public void ResetGame()
        {
            // Implementation to reset the game
        }
    }
}