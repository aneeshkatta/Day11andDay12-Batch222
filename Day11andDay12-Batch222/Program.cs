using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11andDay12_Batch222
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------Player:1-----------------");
            Player player1 = new Player();
            player1.CardDeck();
            Console.WriteLine("---------------Player:2-----------------");
            Player player2 = new Player();
            player2.CardDeck();
            Console.WriteLine("---------------Player:3-----------------");
            Player player3 = new Player();
            player3.CardDeck();
            Console.WriteLine("---------------Player:4-------------------");
            Player player4 = new Player();
            player4.CardDeck();
        }
    }
}