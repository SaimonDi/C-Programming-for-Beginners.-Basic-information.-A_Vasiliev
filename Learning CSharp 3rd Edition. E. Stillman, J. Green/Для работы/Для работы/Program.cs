using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Для_работы {
    class Program {
        static void Main(string[] args) {
            List<double> balls = new List<double> {0.654614,4.415750 };
            double summ=0;
            for(int i = 0; i < balls.Count; i++) {
                summ += balls[i];
                }
            Console.WriteLine(summ);
            Console.ReadKey();
            }
        }
    }
