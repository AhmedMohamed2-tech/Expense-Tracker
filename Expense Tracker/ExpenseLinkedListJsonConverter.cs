using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Expense_Tracker
{
    public class ExpenseLinkedListJsonConverter : JsonConverter<ExpenseLinkedList>
    {
        public override ExpenseLinkedList Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var expenses = JsonSerializer.Deserialize<List<Expense>>(ref reader, options);
            var expenseList = new ExpenseLinkedList();
            foreach (var expense in expenses)
            {
                expenseList.Add(expense);
            }
            return expenseList;
        }

        public override void Write(Utf8JsonWriter writer, ExpenseLinkedList value, JsonSerializerOptions options)
        {
            var expenses = new List<Expense>();
            foreach (var expense in value.GetAll())
            {
                expenses.Add(expense);
            }
            JsonSerializer.Serialize(writer, expenses, options);
        }
    }
}
