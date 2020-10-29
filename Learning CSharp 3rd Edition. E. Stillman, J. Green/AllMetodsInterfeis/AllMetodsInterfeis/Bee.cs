using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMetodsInterfeis {
    class Bee : IStingPatrol {
        public int AllertLevel { get; }
        public int StingerLength { get; set; }

        public bool LookForEnemies() {
            throw new NotImplementedException();
            }

        public int SharpenStinger(int length) {
            throw new NotImplementedException();
            }
        }
    }
