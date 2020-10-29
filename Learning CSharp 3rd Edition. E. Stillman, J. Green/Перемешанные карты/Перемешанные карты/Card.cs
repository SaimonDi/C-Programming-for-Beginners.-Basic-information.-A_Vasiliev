using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перемешанные_карты {
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
        }
    }
