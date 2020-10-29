using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_Managment {
    class Queen : Bee {
        public Queen (Worker[] workers, double weightMg) : base(weightMg)  {
            this.workers = workers;
            }

        private Worker[] workers;
        private int shiftNumber=0;
        
        public bool AssignWork(string job, int numberOfShifts) {
            for(int i = 0; i < workers.Length; i++) 
                if(workers[i].DoThisJob(job, numberOfShifts))
                    return true;
            return false;
            }
        
        public string WorkTheNextShifts() {
            double honeyConsumed = HoneyConsumptionRate();
            shiftNumber++;
            string report = "Отчет для смены #" + shiftNumber + "\r\n";
            for(int i = 0; i < workers.Length; i++) {

                honeyConsumed += workers[i].HoneyConsumptionRate();

                if(workers[i].DidYouFinish())
                    report += "Рабочий #" + (i + 1) + " закончил работу\r\n";
                if(String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Рабочий #" + (i + 1) + " не работает\r\n";
                else if(workers[i].ShiftLeft > 0)
                    report += "Рабочий #" + (i + 1) + " выполняет '" + workers[i].CurrentJob + "' ещё " + workers[i].ShiftLeft + " смен\r\n";
                else
                    report += "Рабочий #" + (i + 1) + " закончит '" + workers[i].CurrentJob + "' после этой смены\r\n";
                }

            report += "Мёда за смену съедено: " + honeyConsumed + " шт.\r\n";
            
            return report;
            }
        }
    }
