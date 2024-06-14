
/*
 * Name : Nishadi L P W Wasala M
 * Student No: S00232446
 * Date :29th of january 2023
 * A Program of Black Jack Game
 * 
 * 
 * Steps
 * 1. Arrys and variables,
 * 2. Get Card  Information - Player's Bet, Dealer's Bet, 
 *                            Player' Cards and Ther Value, 
 *                            Dealer's Card and There values
 * 3. Create  Object
 * 4. Display Results
 * 5. Display Instruction Methode
 * 6. Ask Ace Card Value
 * 7. Assign Value of Card Using Switch Methode
 * 8. Assigng Ace card value
 * 9. Get Information 
 * 

 * 
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //Steps
            //Arrys and variables,
            string[] player = new string[2];
            string[] dealer = new string[20];
            string[] twist = new string[2];

            int playerScore, accWorth, totall2, totalTwist, counter, dealerScore;
            int input, getValue2, getValueDealer, accWorthTwist, playerScoreTwist2, accWorthDealer, totalDealer;
            int aceValue1, aceValue2, aceValueDealer,   playerTotalScore, playerScore2, getValueDealer2, accWorthDealer2, totalDealer2;
            int totalScoreDealer;
            string value;
            string response = "";

            Console.OutputEncoding = Encoding.UTF8;
          

            Console.WriteLine("The Black jack Game");
           

            while (response != "-1") //While Loop For Exit The Game
            {
                //Assign Values 

                accWorth = 0;
                totall2 = 0;
                totalTwist = 0;
                accWorthTwist = 0;
                playerScoreTwist2 = 0;
                accWorthDealer = 0;
                totalDealer = 0;
                dealerScore = 0;
                counter = 0;
                accWorthDealer2 = 0;
                totalDealer2 = 0;


                //Call value of money 
                string playerMoney = GetValueOfMoney(" Player  Bet");
                int moneyOfPlayer = Convert.ToInt32(playerMoney);
                string dealerMoney = GetValueOfMoney(" Dealer  Bet");
                int moneyOfDealer = Convert.ToInt32(dealerMoney);
               
                Console.Clear();

                DisplayInstruction(); // Display Game Instruction

                //Palyer Insert Cards
                Console.WriteLine("\n\nPlayer :");

                // Player' Cards and Ther Value,
                for (int i = 0; i < 2; i++)
                {


                    Console.WriteLine("\nPleas Enter your Card  >> {0}", i + 1);
                    player[i] = Console.ReadLine().ToLower();

                    value = player[i];



                    if (player[i] == "ace of clubs" || player[i] == "ace of hearts" || player[i] == "ace of spades" || player[i] == "ace of diamond")
                    {

                        AceCardValue();
                        string input1 = Console.ReadLine();
                        input = AceWorthGet(input1);


                        Console.WriteLine(" \nCard dealt is the {0} , value {1}", player[i], input);
                        aceValue1 = input;

                        accWorth += input;
                    }
                    else
                    {
                        int playerValue = ValueOfCards(value);
                        Console.WriteLine("\nCard dealt is the {0} , value {1}", player[i], playerValue);


                        totall2 += playerValue;



                    }
                    Console.WriteLine("\n\nYour Curruent Score : {0}", totall2 + accWorth);
                }
                playerScore2 = totall2 + accWorth; 




                Console.WriteLine("\n\nDo yo need stic or twist  Please enter\t- s/t");
                string game = Console.ReadLine();

                if (game == "t")
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine("\nPleas Enter your Card  >> {0}", i + 3);
                        twist[i] = Console.ReadLine().ToLower();

                        value = twist[i];


                        if (twist[i] == "ace of clubs" || twist[i] == "ace of hearts" || twist[i] == "ace of spades" || twist[i] == "ace of diamond")
                        {

                            AceCardValue();
                            string input2 = Console.ReadLine();
                            getValue2 = AceWorthGet(input2);


                            Console.WriteLine(" \n\nCard dealt is the {0} , value {1}", twist[i], getValue2);
                            aceValue2 = getValue2;

                            accWorthTwist += aceValue2;
                        }
                        else
                        {
                            int playerValuetwist = ValueOfCards(value);
                            Console.WriteLine(" \n\nCard dealt is the {0} , value {1}", twist[i], playerValuetwist);


                            totalTwist += playerValuetwist;


                        }
                        Console.WriteLine("\nYour Current Score is : {0}", playerScore2 + totalTwist + accWorthTwist);

                    }
                    playerScoreTwist2 = totalTwist + accWorthTwist;
                     playerTotalScore = playerScoreTwist2 + playerScore2;
                   

                }
                else
                {

                    playerScoreTwist2 = 0;

                }
                Console.WriteLine("\n\nPlayer Score is {0}", playerScore2 + playerScoreTwist2);



                //Dealer Insert There Cards
                Console.WriteLine("\n\n\nDealer :");

                for (int i = 0; i < 2; i++)
                {
                  
                    Console.WriteLine("\nPleas Enter your Card  {0}>> ", (i + 1));
                    dealer[counter] = Console.ReadLine();
                    value = dealer[counter];
                    if (dealer[counter] == "ace of clubs" || dealer[counter] == "ace of hearts" || dealer[counter] == "ace of spades" || dealer[counter] == "ace of diamond")
                    {

                        AceCardValue();
                        string inputDealer = Console.ReadLine();
                        getValueDealer = AceWorthGet(inputDealer);


                        Console.WriteLine(" \nCard dealt is the {0} , value {1}", dealer[counter], getValueDealer);
                        aceValueDealer = getValueDealer;

                        accWorthDealer += aceValueDealer;
                    }
                    else
                    {
                        int dealerValue = ValueOfCards(value);
                        Console.WriteLine(" \nCard dealt is the {0} , value {1}", dealer[counter], dealerValue);


                        totalDealer += dealerValue;



                    }

                    Console.WriteLine("\nYour Current Score : {0}", totalDealer + accWorthDealer);
                     totalScoreDealer = totalDealer + accWorthDealer;
                    

                   
                }

                // Total of Dealer First Two Cards

                totalScoreDealer = totalDealer + accWorthDealer;

                // This While Code Run, If Dealer's First Two Cards less than 17

                while (dealerScore < 21 && totalScoreDealer < 17)

                {


                    Console.WriteLine("\nPleas Enter your Card  >> ");
                    dealer[counter] = Console.ReadLine();
                    value = dealer[counter];

                    if (dealer[counter] == "ace of clubs" || dealer[counter] == "ace of hearts" || dealer[counter] == "ace of spades" || dealer[counter] == "ace of diamond")
                    {

                        Console.WriteLine("Do you want to select - 1 / 11");
                        string inputDealer = Console.ReadLine();
                        getValueDealer2 = AceWorthGet(inputDealer);


                        Console.WriteLine(" \nCard dealt is the {0} , value {1}", dealer[counter], getValueDealer2);
                         int aceValueDealer2 = getValueDealer2;

                        accWorthDealer2 += aceValueDealer2;
                    }
                    else
                    {
                        int dealerValue2 = ValueOfCards(value);
                        Console.WriteLine(" \nCard dealt is the {0} , value {1}", dealer[counter], dealerValue2);


                        totalDealer2 += dealerValue2;



                    }
                    Console.WriteLine("\nYour Current Score : {0}", totalScoreDealer + accWorthDealer2 + totalDealer2);




                    int dealerScore2 = accWorthDealer2 + totalDealer2;
                    dealerScore = accWorthDealer2 + totalDealer2 + totalScoreDealer;
                }


                //dealerScore = accWorthDealer2 + totalDealer2 + totalScoreDealer;


             
                dealerScore = accWorthDealer + totalDealer + totalDealer2 + accWorthDealer2; // Total of Dealer's Cards Value
                playerScore = playerScore2 + playerScoreTwist2; //Total Of Player's Cards value
                
                //Creat Object
                GameOfBlackJack one = new GameOfBlackJack(moneyOfPlayer, moneyOfDealer, playerScore, dealerScore);

                //Display The Results of The Game
                one.PrintDetails();

                Console.WriteLine("\n\npress any key to continue or -1 to quit");
                response = Console.ReadLine();
               

            }

            
        }
        
        //Create Methodes
       
        //Display Instruction
        public static void DisplayInstruction()
        {
            Console.WriteLine("Inbstruction Of The Game \n\n 1. You need to have a hand less than or equal to 21 \n\ti. An Ace is worth 11 or 1. \n\tii. Jack, Queen and King are all worth 10." +
                "\n\tiii. All other cards are their face value\n 2. The dealer deals you two cards and you can decide to stick or twist\n 3. You can receive a card until you stick or go bust (over 21) " +
                "\n 4. Dealer has less than 17 he takes another card and repeats until he has more than 17 or is bust.");
            Console.WriteLine("\nPlease Enter Your Card Like This \n \neg: 5 of clubs or queen of hearts");
            
        }

        //Ask Ace Card Value
        public static void AceCardValue()
        {
            Console.WriteLine("\n\nDo you want to select card value of 1 please enter 1 or value of 11 please" +
                            " enter 11 \t- 1 / 11");
        }

      //Assign Value Of The Cards
        public static int ValueOfCards(string value)
        {

            switch (value)
            {
                case "1 of clubs":
                case "1 of diamond":
                case "1 of hearts":
                case "1 of spades":

                    return 1;
                    break;

                case "2 of clubs":
                case "2 of diamond":
                case "2 of hearts":
                case "2 of spades":

                    return 2;
                    break;
                case "3 of clubs":
                case "3 of diamond":
                case "3 of hearts":
                case "3 of spades":

                    return 3;
                    break;
                case "4 of clubs":
                case "4 of diamond":
                case "4 of hearts":
                case "4 of spades":

                    return 4;
                    break;
                case "5 of clubs":
                case "5 of diamond":
                case "5 of hearts":
                case "5 of spades":

                    return 5;
                    break;
                case "6 of clubs":
                case "6 of diamond":
                case "6 of hearts":
                case "6 of spades":

                    return 6;
                    break;
                case "7 of clubs":
                case "7 of diamond":
                case "7 of hearts":
                case "7 of spades":

                    return 7;
                    break;
                case "8 of clubs":
                case "8 of diamond":
                case "8 of hearts":
                case "8 of spades":

                    return 8;
                    break;
                case "9 of clubs":
                case "9 of diamond":
                case "9 of hearts":
                case "9 of spades":

                    return 9;
                    break;
                case "10 of clubs":
                case "10 of diamond":
                case "10 of hearts":
                case "10 of spades":
                case "queen of clubs":
                case "queen of diamond":
                case "queen of hearts":
                case "queen of spades":
                case "king of clubs":
                case "king of diamond":
                case "king of hearts":
                case "king of spades":
                case "jack of clubs":
                case "jack of diamond":
                case "jack of hearts":
                case "jack of spades":


                    return 10;
                    break;

               

                default:
                    return 0;
                    break;


            }
        }

        //Assign Value of the Ace Card
        public static int AceWorthGet(string input1)
        {
            switch (input1)
            {
                case "1":
                    return 1;
                    break;
                default:
                    return 11;

            }

        
        }

        //Gert Information
        static string GetValueOfMoney(string moneyOfValue)
        {
            Console.WriteLine("\n\n Please Enter {0}", moneyOfValue);
            return  Console.ReadLine();
             
            ;
        }

    }
}
