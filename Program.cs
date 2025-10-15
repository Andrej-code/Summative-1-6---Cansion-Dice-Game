using Die_Casion_Game;

namespace Summative_1_6___Cansion_Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Die die1, die2;
 
            int backAccount = 100;
            int playerBet;
            int totalCount = 0;

            bool done = false;


            die1 = new Die();
            die2 = new Die(ConsoleColor.DarkRed);

            Console.WriteLine("Hi there, Welcome to the Double Chancing Casion!");

            Console.WriteLine();

            while (!done)
            {

                Console.WriteLine("You've got $" + (backAccount + totalCount) + " in your account.");

                Console.WriteLine();

                Console.WriteLine("Enter an amount of how much do you want to bet.");
                while (int.TryParse(Console.ReadLine(), out playerBet));
                {

                    Console.WriteLine("Invaild input, for it not being a number.");
                
                }


                int.TryParse(Console.ReadLine(), out playerBet);

                Console.WriteLine();

                die1 = new Die();
                die2 = new Die(ConsoleColor.DarkRed);

                Console.WriteLine("You've rolled a " + die1);
                die1.DrawRoll();

                Console.WriteLine();

                Console.WriteLine("You've rolled a " + die2);
                die2.DrawRoll();

                Console.WriteLine();


                if (die1.Roll == die2.Roll)
                {

                    Console.WriteLine("Rolled Doubles");

                    Console.WriteLine("Bet is $" + playerBet + ", the player wins $" + (playerBet * 2) + " for a total of $" + (backAccount + playerBet * 2) + " in your bank.");
                    totalCount += playerBet * 2;


                }

                if (die1.Roll != die2.Roll)
                {

                    Console.WriteLine("Didn't Rolld Doubles");

                    Console.WriteLine("Bet is $" + playerBet + ", the player wins $" + (playerBet / 2) + " for a total of $" + (backAccount + playerBet / 2) + " in your bank.");

                    totalCount += playerBet / 2 ;


                }
                
                
                if ((die1.Roll + die2.Roll) % 2 == 0)
                {
                    Console.WriteLine("Rolled an Even/Odd Sum");

                    Console.WriteLine("Bet is $" + playerBet + ", the player wins $" + (playerBet) + " for a total of $" + (backAccount + playerBet) + " in your bank.");

                    totalCount += playerBet;

                }

                //else
                //{

                //    Console.WriteLine("You've lost your bet, hope you come back again for another time.");
                //    Console.WriteLine("And you've made in total $" + totalCount + (backAccount - playerBet) + ".");
                //    done = true;

                //}



            }
           
        }
    }
}
