using System;
namespace RPS
{
    class Program
    {
        enum Choice
        {
            Rock = 0,      // 0
            Paper = 1,     // 1
            Scissors = 2   // 2
        }
        static void Main(string[] args)
        {
            var random = (Choice)new Random().Next(0, 3 );
            var output = random.ToString().ToLower();
            
            var Lose = "Sorry, you lose ;w; maybe git gud lmao";
            var Win = "Damn you beat the pooter at something, good thing it isn't your wife";
            var Draw = "Oh man, you got a draw, see if there's anything inside :>";

            Console.WriteLine("Please Choose Rock, Paper or Scissors");
            string response = Console.ReadLine().ToLower();

            switch(response)
            {
                case "rock":
                    switch(output)
                    {
                        case "rock":
                            Console.WriteLine(Draw);
                            break;
                        case "paper":
                            Console.WriteLine(Lose);
                            break;
                        case "scissors":
                            Console.WriteLine(Win);
                            break;
                        default:
                            Console.WriteLine("Invalid response, please try again");
                            break;
                    }
                    break;
                case "paper":
                    switch(output)
                    {
                        case "rock":
                            Console.WriteLine(Win);
                            break;
                        case "paper":
                            Console.WriteLine(Draw);
                            break;
                        case "scissors":
                            Console.WriteLine(Lose);
                            break;
                    }
                    break;
                case "scissors":
                    switch(output)
                    {
                        case "rock":
                            Console.WriteLine(Lose);
                            break;
                        case "paper":
                            Console.WriteLine(Win);
                            break;
                        case "scissors":
                            Console.WriteLine(Draw);
                            break;
                        default:
                            Console.WriteLine("Invalid Input please try again");
                            break;
                    }
                break;
                default:
                    Console.WriteLine("Invalid input please try agadin");
                    break;
            }
        }
    }
}



            
            
                            
                            
                            