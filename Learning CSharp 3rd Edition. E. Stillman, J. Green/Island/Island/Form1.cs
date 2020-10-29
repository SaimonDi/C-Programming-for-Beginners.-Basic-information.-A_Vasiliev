using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Island {
    public partial class Form1 : Form {
        

        public Form1() {
            InitializeComponent();
            }
        


        private void button1_Click(object sender, EventArgs e) {
            int y = 0;
            int[] index = new int[4] { 1,3,0,2};
            string[] islands = new string[4] { "Bermuda", "Fiji", "Azores", "Cozumel" };
            string result = "";

            int refNum;
            while(y < 4) {
                refNum = index[y];
                result += "\nisland = ";
                result += islands[refNum];
                y++;
                }
            MessageBox.Show(result);
            }
        }
    }
