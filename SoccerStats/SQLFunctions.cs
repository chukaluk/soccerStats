using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SoccerStats
{
    public class SQLFunctions
    {
        private static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Charles\Documents\C#\SoccerStats\SoccerStats\players.mdf;Integrated Security=True");

        public static void refresh(DataGridView dataGridView)
        {
            try
            {
                connection.Open();
                SqlDataAdapter dataAdpater = new SqlDataAdapter("SELECT * FROM [players]", connection);
                DataTable dataTable = new DataTable();
                dataAdpater.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Insert(string name, string team, int goals, int assists)
        {
            try
            {
                connection.Open();
                SqlCommand commandInsert = new SqlCommand("INSERT INTO [players] VALUES(@name, @team, @goals, @assists)", connection);
                commandInsert.Parameters.AddWithValue("@name", name);
                commandInsert.Parameters.AddWithValue("@team", team);
                commandInsert.Parameters.AddWithValue("@goals", goals);
                commandInsert.Parameters.AddWithValue("@assists", assists);
                commandInsert.ExecuteNonQuery();

            }
            catch(SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Delete(int key)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM [players] WHERE Id = @key", connection);
                sqlCommand.Parameters.AddWithValue("@key", key);
                sqlCommand.ExecuteNonQuery();
            }
            catch(SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void UpdateName(string newName, int id)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE [players] SET Name = @newName WHERE Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@newName", newName);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void UpdateTeam(string newTeam, int id)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE [players] SET Team = @newStat WHERE Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@newStat", newTeam);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void UpdateGoals(int newGoals, int id)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE [players] SET Goals = @newGoals WHERE Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@newGoals", newGoals);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void UpdateAssists(int newAssists, int id)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE [players] SET Assists = @newAssists WHERE Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@newAssists", newAssists);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
