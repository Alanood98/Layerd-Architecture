using ServicesLab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLab1.Repositories
{
    public interface ITransactionRepo
    {
        IEnumerable<Transaction> GetAllTransactions();
        Transaction GetTransactionById(int id);
        void AddTransaction(Transaction transaction);
        void UpdateTransaction(Transaction transaction);
        void DeleteTransaction(int id);
    }

   





}
