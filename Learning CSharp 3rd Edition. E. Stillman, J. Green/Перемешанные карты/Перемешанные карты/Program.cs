using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перемешанные_карты {
    class Program {
        static void Main(string[] args) {

            Random random = new Random();
            List<Card> cards = new List<Card>();
            for(int i = 0; i < 5; i++) {
                cards.Add(new Card((Suit)random.Next(4), (Value)random.Next(1, 14)));
                }

            Console.WriteLine("Five random cards:");
            PrintCard(cards);

            Console.WriteLine("\nFive random cards after sort:");
            cards.Sort(new CardComparer_byValue());
            PrintCard(cards);

            Console.ReadKey();
            }

        public static void PrintCard(List<Card> card) {
            foreach(Card cards in card) {
                Console.WriteLine(cards);
                }
            }
        }
    }
