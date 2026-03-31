using System;

namespace Personal_Finance_Tracker.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public string Type { get; set; }   

        public double Amount { get; set; }

        public string Category { get; set; }

        public DateTime Date { get; set; }
    }
}