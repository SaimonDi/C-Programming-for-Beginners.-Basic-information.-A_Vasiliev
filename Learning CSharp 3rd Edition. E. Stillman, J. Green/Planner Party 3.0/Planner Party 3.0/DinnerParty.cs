using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner_Party_3._0 {
    class DinnerParty : Party {
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool helthyOption, bool fancyDecorations) {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = helthyOption;
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
        public override decimal Cost {
            get {
                decimal totalCost = base.Cost;
                totalCost += NumberOfPeople * CalculateCostOfBeveragesPerPerson();
                
                if(HealthyOption) {
                    return totalCost * .95M;
                    } else {
                    return totalCost;
                    }
                }
            }
        }
    }
