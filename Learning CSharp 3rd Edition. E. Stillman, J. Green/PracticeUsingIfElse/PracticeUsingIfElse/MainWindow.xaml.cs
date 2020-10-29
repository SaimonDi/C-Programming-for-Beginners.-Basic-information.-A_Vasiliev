using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticeUsingIfElse {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            }


        private void changeText_Click(object sender, RoutedEventArgs e) {
            if(enableCheckbox.IsChecked != true) {
                //if(labelToChange.Text == "Text changing is disabled") {
                    //labelToChange.Text = "Press the button to change my text";
                    labelToChange.Text = "Text changing is disabled";
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Center;
                    //}
                } else if(labelToChange.HorizontalAlignment == HorizontalAlignment.Left) {
                labelToChange.HorizontalAlignment = HorizontalAlignment.Right;
                labelToChange.Text = "Right";
                } else {
                labelToChange.HorizontalAlignment = HorizontalAlignment.Left;
                labelToChange.Text = "Left";
                }
                }
        }
    }

