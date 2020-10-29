﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGuy {
    public partial class Form1 : Form {

        Guy joe;
        Guy bob;
        int bank = 100;
        
        public Form1() {
            InitializeComponent();
            joe = new Guy() { Cash = 50, Name = "Joe" };
            bob = new Guy() { Cash = 100, Name = "Bob" };
            UpdateForm();
            }

        public void UpdateForm() {
            joeCashLabel.Text = joe.Name + " имеет $" + joe.Cash;
            bobCashLabel.Text = bob.Name + " имеет $" + bob.Cash;
            bankCashLabel.Text = "В банке сейчас $" + bank;
            }

        private void joeRecieveButton_Click(object sender, EventArgs e) {
            if(bank >= 10) {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
                } else {
                MessageBox.Show("В банке нет денег");
                }
            }

        private void bobGiveButton_Click(object sender, EventArgs e) {
            bank += bob.GiveCash(5);
            UpdateForm();
            }

        private void joeGivesToBob_Click(object sender, EventArgs e) {
            bob.Cash += joe.GiveCash(10);
            UpdateForm();
            }

        private void bobGivesToJoe_Click(object sender, EventArgs e) {
            joe.Cash += bob.GiveCash(5);
            UpdateForm();
            }
        }
    }
