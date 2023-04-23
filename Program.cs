
using static Program;

internal class Program
{
    public enum Options
    {
        Rock,
        Paper,
        Scissor,
        Spock,
        Lizard,
        Exit
    }

    static void Main(string[] args)
    {
        int rock = 0;
        int paper = 0;
        int scissors = 0;
        int spock = 0;
        int lizard = 0;

        string userChoice = "";

        int userPoints = 0;
        int kiPoints = 0;

        Options optionsPlayer;
        Enum.TryParse(userChoice, out optionsPlayer);
        Options optionsKi;

        do
        {
            string kiChoice = RandomPick(Kevin(rock, paper, scissors, spock, lizard), Random(), userPoints, kiPoints);
            Enum.TryParse(kiChoice, out optionsKi);

            //Input Validation
            try
            {

                Console.WriteLine("Rock | Paper | Scissor | Spock | Lizard   | Exit");
                Console.WriteLine("-----------------------");
                userChoice = Console.ReadLine();

                //Sliceing the input so the first char is always Uppercase and the rest is Lowercase
                userChoice = (char.ToUpper(userChoice[0]) + (userChoice.Substring(1).ToLower()));
                
                //Checing if the input is in the enums list
                if (!Enum.TryParse(userChoice, out optionsPlayer))
                {
                    Console.Clear();
                    throw new Exception();
                }

                //Output of the match
                Console.WriteLine(kiChoice);
                Console.WriteLine("-----------------------");
                WinChoice(optionsPlayer, ref userPoints,  optionsKi, ref kiPoints, ref rock, ref paper, ref scissors, ref lizard, ref spock);
                Console.WriteLine("Player {0}|{1} Computer", userPoints, kiPoints);
                Console.WriteLine("----------------------- \n\n\n");
            }
            catch
            {
                Console.WriteLine("ERROR Only input the named options \n");
            }


        } while (Options.Exit != optionsPlayer);
        Console.Clear();


        //Choosing between the bot and a random move if the conditions are met
        static string RandomPick(string one, string two, int currentPlayer, int currentComputer)
        {

            if (currentPlayer > 0 && currentPlayer > currentComputer - 1)
            {
                return one;
            }
            else
            {
                return two;
            }
        }

        //Picking random Move
        static string Random()
        {
            string[] ranChoice = { "Rock", "Paper", "Scissor", "Spock", "Lizard" };
            Random random = new Random(DateTime.Now.Millisecond);
            int index = random.Next(ranChoice.Length);
            return ranChoice[index];
        }

        //Basic Bot wich can easily be changed out
        static string Kevin(int rock, int paper, int scissors, int spock, int lizard)
        {

            if (rock > 0 && rock > paper && rock > scissors && rock > spock && rock > lizard)
            {
                return "Paper";
            }
            else if (paper > 0 && paper > rock && paper > scissors && rock > spock && rock > lizard)
            {
                return "Scissor";
            }
            else if (scissors > 0 && scissors > rock && scissors > paper && rock > spock && rock > lizard)
            {
                return "Rock";
            }
            else if (spock > 0 && spock > rock && spock > paper && rock > scissors && rock > spock && rock > lizard)
            {
                return "Lizard";
            }
            else if (lizard > 0 && scissors > rock && scissors > paper && rock > scissors && rock > spock && rock > lizard)
            {
                return "Rock";
            }
            else return Random();

        }

        //Choosing Who Wins
        static void WinChoice(Options optionsPlayer, ref int userPoints,Options computer, ref int computerPoints, ref int rock, ref int paper, ref int scissors, ref int lizard, ref int spock)
        {
            switch (optionsPlayer)
            {
                case Options.Rock:
                    if (computer == Options.Paper)
                    {
                        rock++;
                        computerPoints++;
                        Console.WriteLine("Computer Wins!");
                    }
                    else if (computer == Options.Spock)
                    {
                        rock++;
                        computerPoints++;
                        Console.WriteLine("Computer Wins!");
                    }   
                    else if (computer == Options.Scissor)
                    {
                        rock++;
                        userPoints++;
                        Console.WriteLine("Player Wins!");
                    }
                    else if (computer == Options.Lizard)
                    {
                        rock++;
                        userPoints++;
                        Console.WriteLine("Player Wins!");
                    }
                    else if (computer == Options.Rock)
                    {
                        rock++;
                        Console.WriteLine("Its a Tie!!");
                    }
                    break;

                case Options.Scissor:
                    if (computer == Options.Rock)
                    {
                        scissors++;
                        computerPoints++;
                        Console.WriteLine("Computer Wins!");
                    }
                    else if (computer == Options.Spock)
                    {
                        scissors++;
                        computerPoints++;
                        Console.WriteLine("Computer Wins!");
                    }
                    else if (computer == Options.Paper)
                    {
                        scissors++;
                        userPoints++;
                        Console.WriteLine("Player Wins!");
                    }
                    else if (computer == Options.Lizard)
                    {
                        scissors++;
                        userPoints++;
                        Console.WriteLine("Player Wins!");
                    }
                    else if (computer == Options.Scissor)
                    {
                        scissors++;
                        Console.WriteLine("Its a Tie!!");
                    }
                    break;

                case Options.Lizard:
                    if (computer == Options.Scissor)
                    {
                        lizard++;
                        computerPoints++;
                        Console.WriteLine("Computer Wins!");
                    }
                    else if (computer == Options.Rock)
                    {
                        lizard++;
                        computerPoints++;
                        Console.WriteLine("Computer Wins!");
                    }
                    else if (computer == Options.Paper)
                    {
                        lizard++;
                        userPoints++;
                        Console.WriteLine("Player Wins!");
                    }
                    else if (computer == Options.Spock)
                    {
                        lizard++;
                        userPoints++;
                        Console.WriteLine("Player Wins!");
                    }
                    else if (computer == Options.Lizard)
                    {
                        lizard++;
                        Console.WriteLine("Its a Tie!!");
                    }
                    break;

                case Options.Paper:
                    if (computer == Options.Lizard)
                    {
                        paper++;
                        computerPoints++;
                        Console.WriteLine("Computer Wins!");
                    }
                    else if (computer == Options.Scissor)
                    {
                        paper++;
                        computerPoints++;
                        Console.WriteLine("Computer Wins!");
                    }
                    else if (computer == Options.Rock)
                    {
                        paper++;
                        userPoints++;
                        Console.WriteLine("Player Wins!");
                    }
                    else if (computer == Options.Spock)
                    {
                        paper++;
                        userPoints++;
                        Console.WriteLine("Player Wins!");
                    }
                    else if (computer == Options.Paper)
                    {
                        paper++;
                        Console.WriteLine("Its a Tie!!");
                    }
                    break;

                case Options.Spock:
                    if (computer == Options.Paper)
                    {
                        spock++;
                        computerPoints++;
                        Console.WriteLine("Computer Wins!");
                    }
                    else if (computer == Options.Lizard)
                    {
                        spock++;
                        computerPoints++;
                        Console.WriteLine("Computer Wins!");
                    }
                    else if (computer == Options.Rock)
                    {
                        spock++;
                        userPoints++;
                        Console.WriteLine("Player Wins!");
                    }
                    else if (computer == Options.Scissor)
                    {
                        spock++; ;
                        userPoints++;
                        Console.WriteLine("Player Wins!");
                    }
                    else if (computer == Options.Spock)
                    {
                        spock++;
                        Console.WriteLine("Its a Tie!!");
                    }
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;

            }
        }
    }
}
