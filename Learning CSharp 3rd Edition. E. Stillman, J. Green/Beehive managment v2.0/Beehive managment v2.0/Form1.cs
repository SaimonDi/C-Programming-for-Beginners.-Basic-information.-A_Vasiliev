using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_Managment {
    public partial class Form1 : Form {
        private Queen queen;
        public Form1() {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Сборщик нектара", "Производство меда" },175);
            workers[1] = new Worker(new string[] { "Уход за яйцами", "Обучение пчелиных детенышей" },114);
            workers[2] = new Worker(new string[] { "Уход за ульем", "Патрулирование" },114);
            workers[3] = new Worker(new string[] { "Сборщик нектара", "Производство меда", "Уход за яйцами", "Обучение пчелиных детенышей", "Уход за ульем", "Патрулирование" },155);
            queen = new Queen(workers,275);
            }

        private void btnAssignThisJob_Click(object sender, EventArgs e) {
            if(queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("Для этого задания рабочих нет '" + workerBeeJob.Text + "'", "Матка говорит...");
            else
                MessageBox.Show("Задание '" + workerBeeJob.Text + "' будет закончено через " + shifts.Value + " смен", "Матка говорит...");
            }

        private void nextShift_Click(object sender, EventArgs e) {
            report.Text = queen.WorkTheNextShifts();
            }

        
        }
    }
