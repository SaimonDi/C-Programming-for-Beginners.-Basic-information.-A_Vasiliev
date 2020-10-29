using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сендвичи_от_Джо {
    class MenuMaker {
        public Random Randomaizer;

        string[] Meats = { "Roast beaf", "Salami", "Turkey", "Hum", "Pastrami" };
        string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        string[] Breads = { "rye", "white", "wheat", "pumpernickel", "italian bread", "a roll" };

        public string GetMenuItem() {
            string randomMeat = Meats[Randomaizer.Next(Meats.Length)];
            string randomCondiments = Condiments[Randomaizer.Next(Condiments.Length)];
            string randomBreads = Breads[Randomaizer.Next(Breads.Length)];
            return randomMeat + " with " + randomCondiments + " on " + randomBreads;
            }

        }
    }
