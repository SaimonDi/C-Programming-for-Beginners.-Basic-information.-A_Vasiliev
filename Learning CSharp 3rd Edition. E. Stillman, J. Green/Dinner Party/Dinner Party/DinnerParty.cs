using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner_Party {
    class DinnerParty {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople,bool helthyOption, bool fancyDecorations) {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = helthyOption;
            }
        private decimal CalculateCostOfDecorations() {
            decimal costOfDecorations;
            if(FancyDecorations) {
                costOfDecorations = 15.00m * NumberOfPeople + 50.00m;
                } else {
                costOfDecorations = 7.50m * NumberOfPeople + 30.00m;
                }
            return costOfDecorations;
            }
        private decimal CalculateCostOfBeveragesPerPerson() {
            decimal costOfBeveragesPerPerson;
            if(HealthyOption) {
                costOfBeveragesPerPerson = 5.00M;
                } else {
                costOfBeveragesPerPerson = 20.00M;
                }
            return costOfBeveragesPerPerson;
            }
        public decimal Cost {
            get {
                decimal totalCost= CalculateCostOfDecorations();
                totalCost += NumberOfPeople*(CalculateCostOfBeveragesPerPerson()+CostOfFoodPerPerson);
                if(HealthyOption) {
                    return totalCost * .95M;
                    } else {
                    return totalCost;
                    }
                }
            }
        }
    }
