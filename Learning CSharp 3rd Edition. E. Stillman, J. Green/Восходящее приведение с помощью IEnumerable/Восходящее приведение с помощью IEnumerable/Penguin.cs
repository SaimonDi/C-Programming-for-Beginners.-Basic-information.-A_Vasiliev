using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Восходящее_приведение_с_помощью_IEnumerable {
    class Penguin : Bird {
        public override void Fly() {
            Console.WriteLine("Пингвины не летают!");
            }
        public override string ToString() {
            return "Имя пингвина " + base.Name;
            }
        }
    }
