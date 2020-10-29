using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner_Party_3._0 {
    class Party {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        private decimal CalculateCostOfDecorations() {
            decimal costOfDecorations;
            if(FancyDecorations) {
                costOfDecorations = 15.00m * NumberOfPeople + 50.00m;
                } else {
                costOfDecorations = 7.50m * NumberOfPeople + 30.00m;
                }
            return costOfDecorations;
            }

        public virtual decimal Cost {
            get {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;

                if(NumberOfPeople>12) 
                    totalCost += 100m;
                    
                return totalCost;
                }
            }


        


        }
    }
