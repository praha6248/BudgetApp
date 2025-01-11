using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BudgetApp
{
    internal class transactionDAO
    {
        internal static string cn = "datasource=localhost;port=3306;username=root;password=root;database=transactions;";

        internal static int addOneTransaction(transaction newTransaction)
        {
            try
            {

                MySqlConnection connection = new MySqlConnection(cn);
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `transaction`(`Amount`, `Category`, `Type`, `Date`) VALUES (@amount, @category, @type, @date)", connection);
                command.Parameters.AddWithValue("@amount", newTransaction.amount);
                command.Parameters.AddWithValue("@category", newTransaction.category);
                command.Parameters.AddWithValue("@type", newTransaction.type);
                command.Parameters.AddWithValue("@date", newTransaction.date.ToString("yyyy-MM-dd"));
                int newRows = command.ExecuteNonQuery();
                connection.Close();
                return newRows;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }
        }

        public List<transaction> GetTransactions()
        {
            List<transaction> returnThese = new List<transaction>();

            MySqlConnection connection = new MySqlConnection(cn);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM transaction", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    transaction a = new transaction
                    {
                        id = reader.GetInt32(0),
                        amount = reader.GetInt32(1),
                        category = reader.GetString(2),
                        type = reader.GetString(3),
                        date = DateOnly.FromDateTime(reader.GetDateTime(4)),
                    };
                    returnThese.Add(a);
                }
            }

            connection.Close();

            return returnThese;
        }

        public List<transaction> searchTransaction(string text, string whatSearched)
        {
            List<transaction> returnThese = new List<transaction>();
            string query = text.Equals("All", StringComparison.OrdinalIgnoreCase)
                ? "SELECT * FROM transaction"
                : $"SELECT * FROM transaction WHERE {whatSearched} LIKE @search";

            using (MySqlConnection connection = new MySqlConnection(cn))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (!text.Equals("All", StringComparison.OrdinalIgnoreCase))
                    {
                        command.Parameters.AddWithValue("@search", "%" + text + "%");
                    }

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transaction a = new transaction
                            {
                                id = reader.GetInt32(0),
                                amount = reader.GetInt32(1),
                                category = reader.GetString(2),
                                type = reader.GetString(3),
                                date = DateOnly.FromDateTime(reader.GetDateTime(4)),
                            };
                            returnThese.Add(a);
                        }
                    }
                }
            }

            return returnThese;
        }

        public bool DeleteTransaction(int transactionId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(cn))
                {
                    connection.Open();
                    string query = "DELETE FROM transaction WHERE id = @transactionId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@transactionId", transactionId);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

}
