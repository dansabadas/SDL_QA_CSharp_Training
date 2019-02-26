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
using BankLibrary;
using System.Collections;
using System.Text.RegularExpressions;
using System.Globalization;

namespace TheBankWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly Regex _regex = new Regex("[^0-9.-]+");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateTransactionsButton_Click(object sender, RoutedEventArgs e)
        {
            string transactionsResult = "";
            string summaryResult = "";
            IBank bank = new Bank();
            Typeface myTypeface = new Typeface("Segoe UI");

            

            ArrayList bankTransactions = bank.GenerateFinancialTransactions(Int32.Parse(IterationInputBox.Text));
            foreach(FinancialTransaction financialTransaction in bankTransactions)
            {
                transactionsResult += $"{financialTransaction.CreditedPerson.Name} transfered {financialTransaction.Ammount} to {financialTransaction.DebitedPerson.Name} \n";
            }

            IList<Person> people =  bank.GeneratePersonBalance(bankTransactions);

            foreach(Person person in people)
            {
                summaryResult += $"{person.Name} Ballance: {person.Ballance} \n";
            }

            TransactionsOutput.Text = transactionsResult;
            SummaryOutput.Text = summaryResult;

            FormattedText formattedText = new FormattedText(TransactionsOutput.Text, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, myTypeface, TransactionsOutput.FontSize, Brushes.Red);

            TransactionsOutput.Height = formattedText.Height;
        }

        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }
    }
}
