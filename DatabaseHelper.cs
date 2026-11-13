using System;
using System.Data;
using System.Data.SQLite;

namespace CybersecurityBotGUI
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            // Database file will be created in the same folder as the .exe
            string dbPath = AppDomain.CurrentDomain.BaseDirectory + "chatbot.db";
            connectionString = "Data Source=" + dbPath + ";Version=3;";
        }

        public bool TestConnection()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public void CreateTables()
        {
            string sql = @"
                CREATE TABLE IF NOT EXISTS tasks (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    title TEXT NOT NULL,
                    description TEXT,
                    reminder_date TEXT,
                    status TEXT DEFAULT 'pending',
                    created_at TEXT DEFAULT CURRENT_TIMESTAMP
                );

                CREATE TABLE IF NOT EXISTS activity_log (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    action_type TEXT NOT NULL,
                    description TEXT NOT NULL,
                    timestamp TEXT DEFAULT CURRENT_TIMESTAMP
                );

                CREATE TABLE IF NOT EXISTS quiz_scores (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    player_name TEXT NOT NULL,
                    score INTEGER NOT NULL,
                    total_questions INTEGER NOT NULL,
                    date_played TEXT DEFAULT CURRENT_TIMESTAMP
                );
            ";

            ExecuteNonQuery(sql);
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ExecuteNonQuery Error: " + ex.Message);
                return -1;
            }
        }

        public DataTable ExecuteQuery(string sql)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ExecuteQuery Error: " + ex.Message);
                return new DataTable();
            }
        }

        public object ExecuteScalar(string sql)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ExecuteScalar Error: " + ex.Message);
                return null;
            }
        }
    }
}