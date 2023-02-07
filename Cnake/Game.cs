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
            Console.WriteLine("Drawing apple at x: " + x + " y: " + y);
        }

        public void DrawSnake()
        {
            Console.WriteLine("Drawing snake at current position");
        }

        public void SpawnApple()
        {
            int[] apple = new int[] { new Random().Next(10), new Random().Next(10) };
            Console.WriteLine("Spawning apple at x: " + apple[0] + " y: " + apple[1]);
            DrawApple(apple[0], apple[1]);
        }

        public void MoveSnake()
        {
            Console.WriteLine("Moving snake to next position");
        }

        public void SnakeEatsApple(int[] head, int[] apple)
        {
            if (head[0] == apple[0] && head[1] == apple[1])
            {
                Console.WriteLine("Snake ate the apple!");
            }

            SpawnApple();
        }

        public void StartGame()
        {
            Console.WriteLine("Starting game...");
            SpawnApple();
            DrawSnake();
            Console.WriteLine("Game started!");
        }

        public void ResetGame()
        {
            Console.WriteLine("Resetting game...");
            Console.WriteLine("Game reset!");
        }
    }
}