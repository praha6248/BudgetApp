using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Transactions;
using Microsoft.VisualBasic;
using System.Windows.Forms.DataVisualization.Charting;



namespace BudgetApp
{
    public partial class Form1 : Form
    {
        BindingSource TransactionBindingSource = new BindingSource();
        private transaction selectedRow = null;
        public Form1()
        {

            InitializeComponent();
            initializeCategory();
            initializecomboBox2();
            UpdateChartWithCategoryExpenses();
            UpdateChartWithLast7DaysSpending();
            category.SelectedIndex = 0;
            spendings.AllowUserToAddRows = false;

            LoadTransactions();
        }

        private void UpdateChartWithLast7DaysSpending()
        {
            DateTime currentDate = DateTime.Now;
            List<transaction> transactions = new transactionDAO().GetTransactions();
            var last7DaysTransactions = transactions
                .Where(t => t.date.ToDateTime(new TimeOnly()) >= currentDate.Date)  // Convert DateOnly to DateTime
                .GroupBy(t => t.date)
                .Select(g => new { Date = g.Key, TotalAmount = g.Sum(t => t.amount) })
                .OrderBy(t => t.Date)
                .ToList();
            chart1.Series.Clear();
            Series series = new Series("Spending")
            {
                ChartType = SeriesChartType.Column
            };
            foreach (var transaction in last7DaysTransactions)
            {
                DataPoint point = new DataPoint
                {
                    AxisLabel = transaction.Date.ToString("yyyy-MM-dd"),
                    YValues = new double[] { transaction.TotalAmount }
                };
                series.Points.Add(point);
            }
            chart1.Series.Add(series);
            series.IsValueShownAsLabel = false;
        }
        private void UpdateChartWithCategoryExpenses()
        {
            List<transaction> transactions = new transactionDAO().GetTransactions();
            var categorySums = transactions
                .Where(t => !string.IsNullOrEmpty(t.category))
                .GroupBy(t => t.category)
                .Select(g => new { Category = g.Key, Total = g.Sum(t => t.amount) })
                .OrderByDescending(g => g.Total)
                .ToList();
            chart1.Series.Clear();
            Series series = new Series("Expenses")
            {
                ChartType = SeriesChartType.Doughnut,
                LabelFormat = "{P2}"
            };
            int totalAmount = transactions.Sum(t => t.amount);
            foreach (var category in categorySums)
            {
                double percentage = (double)category.Total / totalAmount * 100;
                series.Points.AddXY(category.Category, category.Total);
                series.Points[series.Points.Count - 1].Label = $"{percentage:0.00}%";
                series.Points[series.Points.Count - 1].LegendText = category.Category;
            }

            series.IsValueShownAsLabel = true;

            chart1.Series.Add(series);
        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string type = "type";
                string what = search.Text;
                PerformSearch(what, type);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void PerformSearch(string what, string type)
        {
            transactionDAO transactionsDAO = new transactionDAO();

            TransactionBindingSource.DataSource = transactionsDAO.searchTransaction(what, type);
            spendings.DataSource = TransactionBindingSource;
        }

        private void initializeCategory()
        {
            category.Items.Add("Housing");
            category.Items.Add("Transportation");
            category.Items.Add("Food");
            category.Items.Add("Utilities");
            category.Items.Add("Personal Spendings");
            category.Items.Add("Entertainment");
        }

        private void initializecomboBox2()
        {
            comboBox2.Items.Add("All");
            comboBox2.Items.Add("Housing");
            comboBox2.Items.Add("Transportation");
            comboBox2.Items.Add("Food");
            comboBox2.Items.Add("Utilities");
            comboBox2.Items.Add("Personal Spendings");
            comboBox2.Items.Add("Entertainment");
        }

        private void LoadTransactions()
        {
            List<transaction> transactions = new transactionDAO().GetTransactions();

            TransactionBindingSource.DataSource = transactions;

            spendings.DataSource = TransactionBindingSource;

            spendings.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewColumn col in spendings.Columns)
                {
                    Console.WriteLine($"Column Name: {col.Name}");
                }
                if (spendings.Columns.Contains("id"))
                {
                    spendings.Columns["id"].Visible = false;
                }
                else
                {
                    Console.WriteLine("Column 'id' not found!");
                }

            };
            int totalAmount = transactions.Sum(t => t.amount);
            total.Text = totalAmount + "z³";
            UpdateChartWithCategoryExpenses();
        }

        private void add_Click(object sender, EventArgs e)
        {
            transaction newTransaction = new transaction();
            if (int.TryParse(amount.Text, out int parsedAmount))
            {
                newTransaction.amount = parsedAmount;
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            newTransaction.category = category.Text;
            newTransaction.type = type.Text;
            newTransaction.date = DateOnly.FromDateTime(DateTime.Now);

            int result = transactionDAO.addOneTransaction(newTransaction);

            if (result > 0)
            {
                LoadTransactions();
            }
            else
            {
                MessageBox.Show("Error adding the transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = "category";
            string what = comboBox2.Text;
            PerformSearch(what, type);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                int transactionId = selectedRow.id;
                transactionDAO transactionsDAO = new transactionDAO();
                if (transactionsDAO.DeleteTransaction(transactionId))
                {
                    LoadTransactions();
                }
                else
                {
                    MessageBox.Show("Failed to delete the transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.", "No Transaction Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void spendings_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var Transaction = TransactionBindingSource[e.RowIndex] as transaction;
            if (Transaction != null)
            {
                selectedRow = Transaction;
            }
        }
    }
}
