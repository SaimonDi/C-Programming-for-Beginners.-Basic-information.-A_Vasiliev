using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Создание_перегруженных_методов {
    class Card {
        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public string Name { get { return Value.ToString() + " of " + Suit.ToString(); } }

        public Card(Suit suit, Value value) {
            Suit = suit;
            Value = value;
            }

        public override string ToString() {
            return Name;
            }

        public static bool DoesCardMatch (Card cardToCheck, Suit suit) {
            if(cardToCheck.Suit == suit)
                return true;
            else
                return false;
            }
        public static bool DoesCardMatch (Card cardToCheck, Value value) {
            if(cardToCheck.Value == value)
                return true;
            else
                return false;
            }

        }
    }
