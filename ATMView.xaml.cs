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
using System.Windows.Shapes;

namespace ATM
{
    /// <summary>
    /// Interaction logic for ATMView.xaml
    /// </summary>
    public partial class ATMView : Window
    {
        public ATMView()
        {
            InitializeComponent();
        }

        private void Withdraw_Click(object sender, RoutedEventArgs e)
        {
            Account a1 = new Account(int.Parse(money.Text));
            string message = a1.Withdraw(a1);
            MessageBox.Show(message);

        }

        private void Deposit_Click(object sender, RoutedEventArgs e)
        {
            Account a2 = new Account(int.Parse(money.Text));
            string message = a2.InsertMoney(a2);
            MessageBox.Show(message);

        }
    }
}
