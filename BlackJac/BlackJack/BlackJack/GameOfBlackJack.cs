/*
 * 
 * * Name : Nishadi L P W Wasala M
 * Student No: S00232446
 * Date :29th of january 2023
 *A Program of Black Jack Game
 * 
 *  Steps
 *  
 * 1. Properties - MoneyOfPlayer,  MoneyOfDealer, PlayerScore, DealerScore   
 * 2. Constructors
 * 3. Methods 
 *  3.1 display details  
 *  3.2 Find The Winner Of The Game
 *  3.3 Calculate Winner get Money

 *  
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class GameOfBlackJack
    {


        //Properties

        public int MoneyOfPlayer { get; set; }
        public int MoneyOfDealer { get; set; }
        public int PlayerScore { get; set; }
        public int DealerScore { get; set; }

        //Constructors
        public GameOfBlackJack( int moneyOfPlayer, int moneyOfDealer, int playerScore, int dealerScore)
        {
            MoneyOfPlayer = moneyOfPlayer;
            MoneyOfDealer = moneyOfDealer;
            PlayerScore = playerScore;
            DealerScore = dealerScore;
        }

        //Methods

        //3.1 display details
        public void PrintDetails()
        {
            Console.Clear();
            Console.WriteLine("\nResults");
            Console.WriteLine("\n\n\tPlayer Score is {0, -25}", PlayerScore);
            Console.WriteLine("\n\tDealer Score is {0, -25}", DealerScore);
            Console.WriteLine("\n\n\tPlayer Money is {0,-25:C}", MoneyOfPlayer);
            Console.WriteLine("\n\n\tDealer Money is {0,-25:C}", MoneyOfDealer);
            Console.WriteLine("\n\n\n\n\t{0}", WinerOfGame());
            Console.WriteLine("\n\tWinner Earn Money\t{0:C}", WinMoney());

        }

        //3.2 Find The Winner Of The Game
        private string WinerOfGame()
        {
         
            if ((PlayerScore <= 21) && (DealerScore > 21))
                {
                return "The Player is the winner of this Comeptition";
            }
            else if ((DealerScore <= 21) && (PlayerScore > 21))
                {
                return "The Dealer is the winner of this Competition";
             }
            else if ((PlayerScore <= 21) && (DealerScore <= 21))
            {
                if (PlayerScore > DealerScore) 
                    
                {
                    return "The Player is the winner of this Comeptition";
                }
                else
                {
                    return "The Dealer is the winner of this Competition";
                }
            }
              else
                return "Player and Dealer are lost the Competition";
        }

        // 3.3 Calculate Winner get Money
        private int WinMoney()
        {
            
            if ((PlayerScore <= 21) && (DealerScore > 21))
            {
                return MoneyOfPlayer + MoneyOfDealer;
            }
            else if ((DealerScore <= 21) && (PlayerScore > 21))
            {
                return MoneyOfPlayer + MoneyOfDealer;
            }
            else if ((PlayerScore <= 21) && (DealerScore <= 21))
            {
                if (PlayerScore > DealerScore)
                {
                    return MoneyOfPlayer + MoneyOfDealer;
                }
                else
                {
                    return MoneyOfPlayer + MoneyOfDealer;
                }
            }
            else
                return 0;
          
        }
    }
}
