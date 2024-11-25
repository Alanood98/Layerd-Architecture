using ServicesLab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLab1.Services
{
    public interface ITransactionService
    {
        IEnumerable<Transaction> GetAllTransactions();
        Transaction GetTransactionById(int id);
        void AddTransaction(Transaction transaction);

    }
}
