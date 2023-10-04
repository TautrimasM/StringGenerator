using MySqlConnector;

namespace StringGenerator;

internal class DbManager
{
    public static void CreateMySqlDatabaseIfNotExist(MySqlConnection connection, string databaseName)
    {
        MySqlCommand cmd = new()
        {
            Connection = connection,
            CommandText = $"CREATE DATABASE IF NOT EXISTS {databaseName}"
        };
        cmd.ExecuteNonQuery();

    }

    public static void CreateTableIfNotExist(MySqlConnection connection)
    {
        MySqlCommand cmd = new()
        {
            Connection = connection,
            CommandText = @"
                    CREATE TABLE IF NOT EXISTS StringTable (
                        ID INT AUTO_INCREMENT PRIMARY KEY,
                        ThreadID INT,
                        Time DATETIME,
                        Data TEXT
                    )"
        };
        cmd.ExecuteNonQuery();

    }

    public static void InsertData(int threadId, DateTime timestamp, string randomString, MySqlConnection connection)
    {
        MySqlCommand cmd = new()
        {
            Connection = connection,
            CommandText = "INSERT INTO StringTable (ThreadID, Time, Data) VALUES (@ThreadID, @Time, @Data)"
        };
        cmd.Parameters.AddWithValue("@ThreadID", threadId);
        cmd.Parameters.AddWithValue("@Time", timestamp);
        cmd.Parameters.AddWithValue("@Data", randomString);
        cmd.ExecuteNonQuery();

    }


}
