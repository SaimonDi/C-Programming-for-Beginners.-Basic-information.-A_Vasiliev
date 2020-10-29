using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingHome {
    class OutsideWithHidingPlace : Outside, IHidingPlace {
        public OutsideWithHidingPlace(string name, bool hot, string hidingPlace) : base(name, hot) {
            HidingLocation = hidingPlace;
            }

        public string HidingLocation { get; private set; }
        public override string Description => base.Description + " Можно спрятаться " + HidingLocation + ".";
        }
    }
