using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;
using CsvHelper;

namespace Expense_Tracker
{
    public static class UserStorage
    {
        private static readonly string filePath = "users.json";

        public static List<User> LoadUsers()
        {
            if (!File.Exists(filePath))
            {
                return new List<User>();
            }

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<User>>(json);
        }

        public static void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users);
            File.WriteAllText(filePath, json);
        }

        public static User GetUserByEmail(string email)
        {
            var users = LoadUsers();
            return users.FirstOrDefault(user => user.Email == email);
        }

        public static void ExportToCsv(List<Expense> expenses, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(expenses);
            }
        }
    }
}
