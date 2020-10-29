using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner_Party_3._0 {
    class BirthdayParty : Party {
        public string CakeWriting { get; set; }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting) {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
            }

        private int ActualLength {
            get {
                if(CakeWriting.Length > MaxWritingLength()) {
                    return MaxWritingLength();
                    } else {
                    return CakeWriting.Length;
                    }
                }
            }
        private int CakeSize() {
            if(NumberOfPeople <= 4)
                return 8;
            else
                return 16;
            }
        private int MaxWritingLength() {
            if(CakeSize() == 8)
                return 16;
            else
                return 40;
            }

        public bool CakeWritingTooLong {
            get {
                if(CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
                }
            }
        
        public override decimal Cost {
            get {
                decimal totalCost = base.Cost;
                
                decimal cakeCost;
                if(CakeSize() == 8)
                    cakeCost = 40m + ActualLength * .25m;
                else
                    cakeCost = 75m + ActualLength * .25m;
                return totalCost + cakeCost;
                }
            }
        }
    }
