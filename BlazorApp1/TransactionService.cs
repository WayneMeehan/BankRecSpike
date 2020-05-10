using BlazorApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1
{
    public class TransactionService
    {
        private Transaction[] _transactions = new[]
            {
                new Transaction{Id=1, Description="Deposit", Reference="ab123", Amount =500.25M, Date = DateTime.Today},
                new Transaction{Id=2, Description="Depost", Reference="ab124", Amount = 10000M, Date= DateTime.Today},
                new Transaction{Id=3, Description="Another deposit", Reference ="aa132", Amount=622.25M, Date = DateTime.Today, MatchedBankTransactionId=1}
            };

        private Transaction[] _bankTransactions = new[]
           {
                new Transaction{Id=1, Description="combined Deposit", Reference="ab1234", Amount =10500.25M, Date = DateTime.Today},
                new Transaction{Id=2, Description="Deposit", Reference="a1222", Amount =324.47M, Date = DateTime.Today},
                new Transaction{Id=3, Description="Random", Reference ="aagdj", Amount=700M, Date = DateTime.Today, MatchedBankTransactionId=1}
            };

        public async Task<IEnumerable<Transaction>> GetTransactionsAsync(bool includeReconciled)
        {
            await Task.Delay(500);
            if (includeReconciled)
            {
                return _transactions;
            }

            return _transactions.Where(x => !x.IsReconciled);
        }

        public bool Reconcile(Transaction transaction, IEnumerable<Transaction> bankTransactions)
        {
            transaction.MatchedBankTransactionId = bankTransactions.First().Id; //too lazy to do this properly
            
            foreach(var bankTransaction in bankTransactions)
            {
                bankTransaction.MatchedBankTransactionId = transaction.Id;
            }

            return true;
        }

        public async Task<IEnumerable<Transaction>> GetBankTransactionsAsync(bool includeReconciled)
        {
            await Task.Delay(500);
            if (includeReconciled)
            {
                return _bankTransactions;
            }

            return _bankTransactions.Where(x => !x.IsReconciled);
        }
    }
}
