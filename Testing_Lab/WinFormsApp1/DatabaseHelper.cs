using Microsoft.Data.SqlClient;
using System.Data;
using static WinFormsApp1.AddEditRequestForm;

namespace WinFormsApp1
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = "Server=(local); Database=test; Integrated Security=true;";

        public static int? TryAuth(string login, string password)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var query = "SELECT [Номер] FROM Сотрудник WHERE Логин = @login AND Пароль = @password";
            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);

            return (int?)cmd.ExecuteScalar();
        }

        public static DataTable GetRequests(string search = "")
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var query = "SELECT * FROM Заявка WHERE [Описание проблемы] LIKE @search";
            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@search", $"%{search}%");

            var adapter = new SqlDataAdapter(cmd);
            var requestsTable = new DataTable();
            adapter.Fill(requestsTable);
            return requestsTable;
        }

        public static int? GetLastIndex(string table = "Заявка")
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            // Прямое использование имени таблицы в запросе
            var query = $"SELECT TOP 1 Номер FROM [{table}] ORDER BY Номер DESC";
            using var cmd = new SqlCommand(query, connection);

            return (int?)cmd.ExecuteScalar();
        }

        public static void UpdateRequest(int id, int client, string priority, DateTime dateAdded, int equipment,
            string issueType, string description, int manager, string faultReason, decimal cost)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var query = "UPDATE Заявка SET [Клиент] = @client, [Приоритет] = @priority, [Дата добавления] = @dateAdded, " +
                        "[Оборудование] = @equipment, [Тип неисправности] = @issueType, [Описание проблемы] = @description, " +
                        "[Исполнитель] = @manager, [Причина неисправности] = @faultReason, [Стоимость выполнения] = @cost WHERE [Номер] = @id";
            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@client", client);
            cmd.Parameters.AddWithValue("@priority", priority);
            cmd.Parameters.AddWithValue("@dateAdded", dateAdded);
            cmd.Parameters.AddWithValue("@equipment", equipment);
            cmd.Parameters.AddWithValue("@issueType", issueType);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@manager", manager);
            cmd.Parameters.AddWithValue("@faultReason", faultReason);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }

        public static void AddRequest(int id, int client, string priority, DateTime dateAdded, int equipment,
            string issueType, string description, int manager, string faultReason, decimal cost)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var query = @"INSERT INTO Заявка ([Номер], [Клиент], [Приоритет], [Дата добавления], [Оборудование], 
                          [Тип неисправности], [Описание проблемы], [Исполнитель], [Причина неисправности], [Стоимость выполнения]) 
                          VALUES (@number, @client, @priority, @dateAdded, @equipment, @issueType, @description, @manager, @faultReason, @cost)";
            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@number", id);
            cmd.Parameters.AddWithValue("@client", client);
            cmd.Parameters.AddWithValue("@priority", priority);
            cmd.Parameters.AddWithValue("@dateAdded", dateAdded);
            cmd.Parameters.AddWithValue("@equipment", equipment);
            cmd.Parameters.AddWithValue("@issueType", issueType);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@manager", manager);
            cmd.Parameters.AddWithValue("@faultReason", faultReason);
            cmd.Parameters.AddWithValue("@cost", cost);

            cmd.ExecuteNonQuery();
        }

        public static List<Client> GetClients()
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var query = "SELECT [Номер], [Имя] FROM Клиенты";
            using var cmd = new SqlCommand(query, connection);

            var clients = new List<Client>();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clients.Add(new Client
                {
                    ClientID = reader.GetInt32(0),
                    ClientName = reader.GetString(1)
                });
            }
            return clients;
        }

        public static List<Equipment> GetEquipment()
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var query = "SELECT [Серийный номер], [Оборудование] FROM Оборудование";
            using var cmd = new SqlCommand(query, connection);

            var equipmentList = new List<Equipment>();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                equipmentList.Add(new Equipment
                {
                    EquipmentID = reader.GetInt32(0),
                    EquipmentName = reader.GetString(1)
                });
            }
            return equipmentList;
        }

        public static decimal GetMaxCost()
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var query = "SELECT MAX(TRY_CAST([Стоимость выполнения] AS decimal(10, 2))) FROM Заявка";
            using var cmd = new SqlCommand(query, connection);
            var result = cmd.ExecuteScalar();
            return result != DBNull.Value ? (decimal)result : 0; // Возвращаем 0, если в таблице нет записей
        }

        public static decimal GetMinCost()
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var query = "SELECT MIN(TRY_CAST([Стоимость выполнения] AS decimal(10, 2))) FROM Заявка";
            using var cmd = new SqlCommand(query, connection);
            var result = cmd.ExecuteScalar();
            return result != DBNull.Value ? (decimal)result : 0; // Возвращаем 0, если в таблице нет записей
        }

        public static int GetTotalRequests()
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var query = "SELECT COUNT(*) FROM Заявка";
            using var cmd = new SqlCommand(query, connection);
            return (int)cmd.ExecuteScalar();
        }

        public static decimal GetAverageCost()
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var query = "SELECT AVG(TRY_CAST([Стоимость выполнения] AS decimal(10, 2))) FROM Заявка";
            using var cmd = new SqlCommand(query, connection);
            var result = cmd.ExecuteScalar();
            return result != DBNull.Value ? (decimal)result : 0; // Возвращаем 0, если в таблице нет записей
        }
    }
}
