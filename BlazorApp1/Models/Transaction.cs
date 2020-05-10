using System;

namespace BlazorApp1.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int? MatchedBankTransactionId { get; set; }
        public bool IsReconciled => MatchedBankTransactionId != null;
    }
}
