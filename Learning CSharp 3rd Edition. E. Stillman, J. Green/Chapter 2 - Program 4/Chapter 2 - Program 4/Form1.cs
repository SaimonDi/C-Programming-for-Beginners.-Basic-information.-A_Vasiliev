using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_2___Program_4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            }

        private void changeText_Click(object sender, EventArgs e) {
            if(enableCheckBox.Checked==true) {
                if(lableToChange.Text=="Right") {
                    lableToChange.Text = "Left";
                    lableToChange.TextAlign = ContentAlignment.MiddleLeft;
                    } else {
                    lableToChange.Text = "Right";
                    lableToChange.TextAlign = ContentAlignment.MiddleRight;
                    }
                } else {
                lableToChange.Text = "Text changing is disabled";
                lableToChange.TextAlign = ContentAlignment.MiddleCenter;
                }
            }
        }
    }
