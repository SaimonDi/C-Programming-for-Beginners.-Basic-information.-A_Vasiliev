using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingHome {
    class RoomWithHidingPlace : Room, IHidingPlace {
        
        public RoomWithHidingPlace(string name, string decoration, string hidingPlace) : base(name, decoration) {
            HidingLocation = hidingPlace;
            }

        public string HidingLocation { get; private set; }

        public override string Description => base.Description + " Спрятаться можно " + HidingLocation + ".";
        }
    }
