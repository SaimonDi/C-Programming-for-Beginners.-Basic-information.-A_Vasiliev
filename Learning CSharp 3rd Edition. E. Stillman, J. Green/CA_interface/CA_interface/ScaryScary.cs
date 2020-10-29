using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_interface {
    class ScaryScary : FunnyFunny, IScaryClown {

        public ScaryScary(string funnyItems, int numberOfScaryThing) : base (funnyItems) {
            this.numberOfScaryThing = numberOfScaryThing;
            }
        
        private int numberOfScaryThing;
        public string ScaryThingIHave { get { return "I have: "+  numberOfScaryThing.ToString() + " spiders"; } }

        public void ScareLittleChildren() {
            Console.WriteLine(ScaryThingIHave);
            }
        }
    }
