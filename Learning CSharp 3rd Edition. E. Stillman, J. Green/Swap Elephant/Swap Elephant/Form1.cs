using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap_Elephant {
    public partial class Form1 : Form {

        Elephant lucinda;
        Elephant lloyd;

        public Form1() {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            }

        private void btnFirstElephant_Click(object sender, EventArgs e) {
            lloyd.WhoAmI();
            }

        private void btnSecondElephant_Click(object sender, EventArgs e) {
            lucinda.WhoAmI();
            }

        private void btnSwapElephant_Click(object sender, EventArgs e) {
            Elephant swap = lucinda;
            lucinda = lloyd;
            lloyd = swap;
            btnFirstElephant.Text = lloyd.Name;
            btnSecondElephant.Text = lucinda.Name;
            MessageBox.Show("Замена слонов!", "Swap elephant");
            }
        }
    }
