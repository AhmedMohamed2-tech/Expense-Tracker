using System;
using System.Collections.Generic;

namespace Expense_Tracker
{
    public class ExpenseNode
    {
        public Expense Data { get; set; }
        public ExpenseNode Next { get; set; }

        public ExpenseNode(Expense data)
        {
            Data = data;
            Next = null;
        }
    }

    public class ExpenseLinkedList
    {
        private ExpenseNode head;

        public void Add(Expense expense)
        {
            var newNode = new ExpenseNode(expense);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Remove(Expense expense)
        {
            if (head == null) return;

            if (head.Data == expense)
            {
                head = head.Next;
                return;
            }

            var current = head;
            while (current.Next != null && current.Next.Data != expense)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        public IEnumerable<Expense> GetAll()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<Expense> QueryByDateRange(DateTime startDate, DateTime endDate)
        {
            var current = head;
            while (current != null)
            {
                if (current.Data.Date >= startDate && current.Data.Date <= endDate)
                {
                    yield return current.Data;
                }
                current = current.Next;
            }
        }
    }
}
