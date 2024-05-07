using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
            public ProgressBar x;
            public double y;
            public int VauleNegr;
            public int VauleNegrFace;
            public int VauleNormGay;
        public MainWindow()
        {
            InitializeComponent();
            ProgresBarNegr.Value = VauleNegr;
            ProgresBarNegrFace.Value = VauleNegrFace;
            ProgresBarNormGay.Value = VauleNormGay;
            ProgresBarNegr.Maximum = 5000;
            ProgresBarNegrFace.Maximum = 5000;
            ProgresBarNormGay.Maximum = 5000;
            x = ProgresBarNegr;
            y = VauleNegr;
            if (ProgresBarNegr.Value == ProgresBarNegr.Maximum && ProgresBarNegrFace.Value == ProgresBarNegrFace.Maximum && ProgresBarNormGay.Value == ProgresBarNormGay.Maximum)
            { 
            Image.Visibility = Visible;
            }
        }

        private void Clicker_Click(object sender, RoutedEventArgs e)
        {
            x.Value += 10;
            if (x.Value >= 100 && x.Value < 200)
            {
                x.Value += 10;
            }
            if (x.Value >= 200 && x.Value < 300)
            {
                x.Value += 30;
            }
            if (x.Value >= 300)
            {
               x.Value += 40;
            }
        }

        private void LocationOne_Click(object sender, RoutedEventArgs e)
        {
            x = ProgresBarNegr;
        }

        private void LocationTwo_Click(object sender, RoutedEventArgs e)
        {
            x = ProgresBarNegrFace;
        }

        private void LocationThree_Click(object sender, RoutedEventArgs e)
        {
            x = ProgresBarNormGay;
        }
        
    }
}
