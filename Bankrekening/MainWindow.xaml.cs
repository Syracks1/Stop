using Bankrekening.classes;
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

namespace Bankrekening
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public baseRekening newRekening;
        public enum rekeningen { Luca, Henk};
        public baseRekening left;
        public baseRekening right;
        public MainWindow()
        {
            InitializeComponent();

            left = new baseRekening(rekeningen.Luca.ToString());
            right = new baseRekening(rekeningen.Henk.ToString());

            left.WriteFile();

            lblNameLeft.Content = left.Naam;
            lblNumLeft.Content = left.Rekeningnummer;

            lblNameRight.Content = right.Naam;
            lblNumRight.Content = right.Rekeningnummer;
        }

        // Left
        private void BtnTakeLeft_Click(object sender, RoutedEventArgs e)
        {
            int request = Convert.ToInt32(tbxLeft.Text);

            int taken = left.Take(request);
            lblMonLeft.Content = taken.ToString();
        }

        private void BtnStortLeft_Click(object sender, RoutedEventArgs e)
        {
            int request = Convert.ToInt32(tbxLeft.Text);

            int add = left.Add(request);
            lblMonLeft.Content = add.ToString();
        }

        // Right
        private void BtnTakeRight_Click(object sender, RoutedEventArgs e)
        {
            int request = Convert.ToInt32(tbxRight.Text);

            int taken = right.Take(request);
            lblMonRight.Content = taken.ToString();

        }

        private void BtnStortRight_Click(object sender, RoutedEventArgs e)
        {
            int request = Convert.ToInt32(tbxRight.Text);

            int add = right.Add(request);
            lblMonRight.Content = add.ToString();
        }


    }
}
