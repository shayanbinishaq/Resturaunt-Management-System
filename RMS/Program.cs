using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace RMS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                EnsureDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize database: " + ex.Message, "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }

        private static void EnsureDatabase()
        {
            string dbPath = DatabaseHelper.DbPath;
            // Ensure directory exists
            string dir = Path.GetDirectoryName(dbPath) ?? AppDomain.CurrentDomain.BaseDirectory;
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            string connectionString = DatabaseHelper.ConnectionString;

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    // Users table
                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Users (
                                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            Username TEXT NOT NULL UNIQUE,
                                            Password TEXT NOT NULL
                                        );";
                    cmd.ExecuteNonQuery();

                    // Items table
                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS items (
                                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            i_name TEXT,
                                            Category TEXT,
                                            Price INTEGER
                                        );";
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
    }
}