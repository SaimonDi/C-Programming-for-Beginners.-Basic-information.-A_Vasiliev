using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_interface {
    
    class Program {
        static void Main(string[] args) {
            TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Jimmy" };
            tallGuy.TalkAboutYourself();
            tallGuy.Honk();
            Console.WriteLine("\r\n");

            ScaryScary fingersTheClown = new ScaryScary("big shoes", 14);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();

            Console.ReadKey();
            }
        }

    class TallGuy : IClown {
        public string FunnyThingIHave { get { return "большие ботинки"; } }
        public void Honk() {
            Console.WriteLine("Honk honk!");
            }

        public string Name;
        public int Height;

        public void TalkAboutYourself() {
            Console.WriteLine("My name is " + Name + " and I'm " + Height + " inchess tall.");
            }

        }
    }
