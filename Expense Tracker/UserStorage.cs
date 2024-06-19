using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Expense_Tracker
{
    public static class UserStorage
    {
        private static string filePath = "users.json";

        public static List<User> LoadUsers()
        {
            if (!File.Exists(filePath))
            {
                return new List<User>();
            }

            var options = new JsonSerializerOptions
            {
                Converters = { new ExpenseLinkedListJsonConverter() }
            };

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<User>>(json, options);
        }

        public static void SaveUsers(List<User> users)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new ExpenseLinkedListJsonConverter() }
            };

            var json = JsonSerializer.Serialize(users, options);
            File.WriteAllText(filePath, json);
        }
    }
}
