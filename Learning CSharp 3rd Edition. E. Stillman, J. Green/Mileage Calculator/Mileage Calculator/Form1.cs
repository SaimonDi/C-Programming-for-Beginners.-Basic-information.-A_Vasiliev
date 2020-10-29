using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mileage_Calculator {
    public partial class Form1 : Form {

        int startingMileage; //Стартовые мили
        int endingMileage; //Конечное число миль
        double milesTraveled; //Пройдено миль
        double reimburseRate=.39; //Коэфициент возмещения
        double amountOwed; //Должны денег

        public Form1() {
            InitializeComponent();
            }

        private void btnCalculate_Click(object sender, EventArgs e) {
            startingMileage = (int)numStartMileage.Value;
            endingMileage = (int)numEndMileage.Value;
            if(endingMileage >= startingMileage) {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                lblResultAmountOwed.Text = "$" + amountOwed;
                } else {
                MessageBox.Show("Начальный пробег не может превышать конечный.", "Невозможно рассчитать");
                }
            }

        private void btnDisplayMiles_Click(object sender, EventArgs e) {
            MessageBox.Show(milesTraveled + " мили", "Пройденные мили");
            }
        }
    }
