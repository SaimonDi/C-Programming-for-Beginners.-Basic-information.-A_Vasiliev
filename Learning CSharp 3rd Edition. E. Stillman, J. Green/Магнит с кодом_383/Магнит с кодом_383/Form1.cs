using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Магнит_с_кодом_383 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            }
        string result = "";
        string zilch = "zero";
        string first = "one";
        string second = "two";
        string third = "three";
        string fourth = "4.2";
        string twopointtwo = "2.2";

        List<string> a = new List<string>();

        public void printL (List<string> a) {
            a.Add(zilch);
            a.Add(first);
            a.Add(second);
            a.Add(third);
            a.RemoveAt(2);
            if(a.Contains("three"))
                a.Add("four");
            if(a.Contains("two"))
                a.Add(twopointtwo);
            if(a.IndexOf("four") != 4)
                a.Add(fourth);
            foreach(string element in a) {
                result += "\n" + element;
                }
            MessageBox.Show(result);
            }

        private void button1_Click(object sender, EventArgs e) {
            printL(a);
            }
        }
    }
