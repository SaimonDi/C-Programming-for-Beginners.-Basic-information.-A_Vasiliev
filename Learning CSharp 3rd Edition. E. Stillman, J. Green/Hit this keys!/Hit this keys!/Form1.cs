using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hit_this_keys_ {
    public partial class Form1 : Form {
        Random random = new Random();
        Stats stats = new Stats();

        public Form1() {
            InitializeComponent();
            }

        private void timer1_Tick(object sender, EventArgs e) {
            //Добавим случайную клавишу к элементу ListBox
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if(listBox1.Items.Count>7) {
                listBox1.Items.Clear();
                listBox1.Items.Add("Игра окончена!");
                timer1.Stop();
                }
            }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            // Если пользователь правильно нажимает клавишу, удалите букву из ListBox
            // и увеличьте скорость появления букв
            if(listBox1.Items.Contains(e.KeyCode)) {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if(timer1.Interval>400) timer1.Interval -= 8;
                if(timer1.Interval>250) timer1.Interval -= 5;
                if(timer1.Interval>100) timer1.Interval -= 2;
                difficultyProgressBar.Value = 800 - timer1.Interval;

                // При правильном нажатии клавиши обновляем объект Stats,
                // вызывая метод Update() с аргументом true
                stats.Update(true);
                } else {
                // При неправильном нажатии клавиши обновляем объект Stats,
                // вызывая метод Update() с аргументом false
                stats.Update(false);
                }
            // Обновление меток элемента StatusStrip
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
            }
        }
    }
