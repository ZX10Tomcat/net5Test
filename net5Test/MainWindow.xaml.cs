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

namespace net5Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        BillRecord bill1r = new(Id: "1", Type: "XVA", Amount: 10);
        BillRecord bill2r = new(Id: "1", Type: "XVA", Amount: 10);

        BillClass bill1c = new("1", "XVA", 10);
        BillClass bill2c = new("1", "XVA", 10);
        public MainWindow()
        {
            InitializeComponent();
            this.RecordTextBox.Text = string.Empty;
            this.ClassTextBox.Text = string.Empty;           
        }

        // Records are immutable
        record BillRecord (string Id, string Type, double Amount);

        //record TestRecord(string Id, string Type, double Amount)
        //{ 
        //    public string Summary { get => $"{Type} {Amount}"; }

        //    string Dosemthing()
        //    {
        //        return "Records can contain methods";
        //    }

        //};

        class BillClass
        {
            public string Id { get; set; }
            public string Type { get; set; }
            public double Amount { get; set; }

            public BillClass(string id, string type, double amount)
            {
                Id = id;
                Type = type;
                Amount = amount;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.RecordTextBox.AppendText($"bill1r.ToString(): { bill1r.ToString() + Environment.NewLine}");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.ClassTextBox.AppendText($"bill1c.ToString(): {bill1c.ToString() + Environment.NewLine}");
        }

        private void equalsRecords_Click(object sender, RoutedEventArgs e)
        {
            this.RecordTextBox.AppendText($"Equals(bill1r, bill2r): {Equals(bill1r, bill2r) + Environment.NewLine}");
        }

        private void equalsClasses_Click(object sender, RoutedEventArgs e)
        {
            this.ClassTextBox.AppendText($"Equals(bill1c, bill2c): {Equals(bill1c, bill2c) + Environment.NewLine}");
        }

        private void ReferenceRecord_Click(object sender, RoutedEventArgs e)
        {
            this.RecordTextBox.AppendText($"ReferenceEquals(bill1r, bill2r): {ReferenceEquals(bill1r, bill2r) + Environment.NewLine}");
        }

        private void ReferenceClass_Click(object sender, RoutedEventArgs e)
        {
            this.ClassTextBox.AppendText($"ReferenceEquals(bill1c, bill2c): {ReferenceEquals(bill1c, bill2c) + Environment.NewLine}");
        }

        private void Record_eq_Click(object sender, RoutedEventArgs e)
        {
            this.RecordTextBox.AppendText($"bill1r == bill2r: {(bill1r == bill2r) + Environment.NewLine}");
        }

        private void Bill_eq_Click(object sender, RoutedEventArgs e)
        {
            this.ClassTextBox.AppendText($"bill1c == bill2c: {(bill1c == bill2c) + Environment.NewLine}");
        }

        private void Record_getHashCode_Click(object sender, RoutedEventArgs e)
        {
            this.RecordTextBox.AppendText($"bill1r.GetHashCode(): {bill1r.GetHashCode() + Environment.NewLine}bill2r.GethasCode(): { bill2r.GetHashCode() + Environment.NewLine}");
        }

        private void Class_getHashCode_Click(object sender, RoutedEventArgs e)
        {
            this.ClassTextBox.AppendText($"bill1c.GetHashCode(): {bill1c.GetHashCode() + Environment.NewLine}bill2c.GethasCode(): { bill2c.GetHashCode() + Environment.NewLine}");
        }

        private void Record_deconstruct_Click(object sender, RoutedEventArgs e)
        {
            var (id, type, amount) = bill1r;
            this.RecordTextBox.AppendText($"var (id, type, amount) = bill1r: id={id}, type={type}, amount={amount} {Environment.NewLine}");
        }

        private void Record_newValue_Click(object sender, RoutedEventArgs e)
        {
            BillRecord newBill = bill1r with { Amount = 25};
            this.RecordTextBox.AppendText($"bill1r with new amount: { newBill.ToString() + Environment.NewLine}");
        }

        private void Open_NewWindow_Click(object sender, RoutedEventArgs e)
        {
            Window conclusion = new Conclusion();

            conclusion.Show();
        }
    }
}
