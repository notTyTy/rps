using System;
namespace RPS
{
    class Program
    {
        enum Choice
        {
            rock,
            paper,
            scissors
        }
        static void Main(string[] args)
        {
            var random = (Choice)new Random().Next(0, 3 );
            var output = random.ToString();
            
            var Lose = "Sorry, you lose ;w; maybe git gud lmao";
            var Win = "You win, congratulations! Sorry there's no prize, maybe the prize is what you experienced along the way ^^";
            var Draw = "Oh man, you got a draw, see if there's anything inside :>";
            var Error = "We've ran into an error, please try again :)";

            Console.WriteLine("Please Choose Rock, Paper or Scissors");
            string response = Console.ReadLine().ToLower(); //converts user input into a more consistent and usable format
            
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
                            Console.WriteLine(Error);
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
                        default:
                            Console.WriteLine(Error);
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
                            Console.WriteLine(Error);
                                break;
                    }
                break;
                default:
                    Console.WriteLine("Invalid input please try again");
                    break;
            }
        }
    }
}



            
            
                            
                            
                            