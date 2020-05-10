using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp1.Models
{
    public class ReconcileViewModel
    {
        private TransactionService _transactionService;

        public Transaction SelectedTransaction { get; private set; }
        public List<Transaction> SelectedBankTransactions { get; private set; }

        public event Action OnChange;

        public ReconcileViewModel(TransactionService transactionService)
        {
            _transactionService = transactionService;
            SelectedBankTransactions = new List<Transaction>();
        }

        public void SetSelectedTransaction(Transaction transaction)
        {
            SelectedTransaction = transaction;
            SelectedBankTransactions.Clear();

            NotifyStateChanged();
        }

        public void AddSelectedBankTransaction(Transaction transaction)
        {
            SelectedBankTransactions.Add(transaction);

            NotifyStateChanged();
        }

        public void RemoveSelectedBankTransaction(Transaction transaction)
        {
            SelectedBankTransactions.Remove(transaction);

            NotifyStateChanged();
        }

        public void Reconcile()
        {
            var reconciled = _transactionService.Reconcile(SelectedTransaction, SelectedBankTransactions);

            SelectedTransaction = null;
            SelectedBankTransactions.Clear();

            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
