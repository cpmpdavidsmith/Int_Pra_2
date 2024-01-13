using System;
namespace Demo
{
    //Define the interface
    public interface Score
    {
        //Declareing the interface methods
        void DisplayScore();
        int Calculate(); 
    }

    public interface Location
    {
        //declaring the interface methods
        void InputCity(String City);
        void DisplayCity();
    }
    public class Player : Score, Location
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        private string City { get; set; }

        //Defining the interface methods
        public void InputCity(string pcity)
        {
            City = pcity;
        }
        public void DisplayCity()
        {
            Console.WriteLine("The player is from" + City);
        }
        public void DisplayScore()
        {
            Console.WriteLine("The score for  try 1 " + Score1);
            Console.WriteLine("The score for try 2 " + Score2);
        }
        public int Calculate()
        {
            return (Score1 + Score2);
        }
    }
    class Program
    {
        //the main function
        static void Main(string[] args)
        {
            Player player1 = new Player();

            player1.PlayerID = 1;
            player1.PlayerName = "John";

            player1.Score1 = 10;
            player1.Score2 = 20;

            player1.DisplayScore();
            Console.WriteLine("The Tota score " + player1.Calculate());

            player1.InputCity("New York");
            player1.DisplayCity();

            Console.Read(); 
        }
    }
}