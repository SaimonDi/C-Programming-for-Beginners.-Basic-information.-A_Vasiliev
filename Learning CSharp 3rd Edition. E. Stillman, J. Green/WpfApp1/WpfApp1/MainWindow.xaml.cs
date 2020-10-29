using System;
using System.Windows;

namespace WpfApp1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            // это комментарий
            string result = "";
            int x = 3;

            while(x > 0) {

            if(x == 1) {
                result = result + "d";
                x = x - 1;
                    break;
                }

            if(x == 2) {
                result = result + "b c";
                }

            if(x > 2) {
                result = result + "a";
                }
               
            x = x - 1;
            result = result + "-";
            }
           
        myLabel.Text = result;
            }

        private void button2_Click(object sender, RoutedEventArgs e) {
            int x = 10;
            if(x == 10) {
                myLabel.Text = "x must be 10";
                } else {
                myLabel.Text = "x isn’t 10";
                }
            }

        private void button3_Click(object sender, RoutedEventArgs e) {
            int someValue = 3;
            string name = "Bobbo Jr.";
            if((someValue == 3) && (name == "Joe")) {
                myLabel.Text = "x is 3 and the name is Joe";
                }
            myLabel.Text = "this line runs no matter what";

            }

        private void button4_Click(object sender, RoutedEventArgs e) {
            int count = 0;
            while(count < 10) {
                count = count + 1;
                }
            for(int i = 0; i < 5; i++) {
                count = count - 1;
                }
            myLabel.Text = "The answer is " + count;
            }
        }
}
