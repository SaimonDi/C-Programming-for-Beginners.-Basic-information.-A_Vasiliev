using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_interface {
    class FunnyFunny : IClown {
        public FunnyFunny(string funnyItems) {
            this.funnyItems = funnyItems;
            }

        private string funnyItems;
        public string FunnyThingIHave { get { return "Hi! I have " + funnyItems; } }

        public void Honk() {
            Console.WriteLine(FunnyThingIHave);
            }
        }
    }
