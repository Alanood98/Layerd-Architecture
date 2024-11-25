using ServicesLab1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServicesLab1.Models;

namespace ServicesLab1.Services
{
    public class BankServices
    //{
    //    private readonly IBankAccountRepository _bankAccountRepository;
    //    private readonly ITransactionService _transactionService;

    //    public BankServices(IBankAccountRepository bankAccountRepository, ITransactionService transactionService)
    //    {
    //        _bankAccountRepository = bankAccountRepository;
    //        _transactionService = transactionService;
    //    }

    //    public void Deposit(int accountId, decimal amount, int sourceAccNumber)
    //    {
    //        var account = _bankAccountRepository.GetAccountById(accountId);
    //        if (account != null)
    //        {
    //            account.Balance += amount;
    //            _bankAccountRepository.UpdateAccount(account);

    //            var transaction = new Transaction
    //            {
    //                Id = accountId,
    //                SourceAccNumber = sourceAccNumber,
    //                Operation = "Deposit",
    //                Amount = amount
    //            };
    //            _transactionService.AddTransaction(transaction);
    //        }
    //        else
    //        {
    //            throw new Exception("Account not found.");
    //        }
    //    }

    //    public void Withdraw(int accountId, decimal amount, int sourceAccNumber)
    //    {
    //        var account = _bankAccountRepository.GetAccountById(accountId);
    //        if (account != null && account.Balance >= amount)
    //        {
    //            account.Balance -= amount;
    //            _bankAccountRepository.UpdateAccount(account);

    //            var transaction = new Transaction
    //            {
    //                Id = accountId,
    //                SourceAccNumber = sourceAccNumber,
    //                Operation = "Withdraw",
    //                Amount = amount
    //            };
    //            _transactionService.AddTransaction(transaction);
    //        }
    //        else
    //        {
    //            throw new Exception("Insufficient funds or account not found.");
    //        }
    //    }

    //    public void Transfer(int sourceAccountId, int destinationAccountId, decimal amount)
    //    {
    //        var sourceAccount = _bankAccountRepository.GetAccountById(sourceAccountId);
    //        var destinationAccount = _bankAccountRepository.GetAccountById(destinationAccountId);

    //        if (sourceAccount != null && destinationAccount != null && sourceAccount.Balance >= amount)
    //        {
    //            sourceAccount.Balance -= amount;
    //            destinationAccount.Balance += amount;

    //            _bankAccountRepository.UpdateAccount(sourceAccount);
    //            _bankAccountRepository.UpdateAccount(destinationAccount);

    //            var sourceTransaction = new Transaction
    //            {
    //                Id = sourceAccountId,
    //                SourceAccNumber = int.Parse(destinationAccount.AccountNumber), 
    //                Operation = "Transfer Out",
    //                Amount = amount
    //            };

    //            var destinationTransaction = new Transaction
    //            {
    //                Id = destinationAccountId,
    //                SourceAccNumber = int.Parse(sourceAccount.AccountNumber), 
    //                Operation = "Transfer In",
    //                Amount = amount
    //            };

    //            _transactionService.AddTransaction(sourceTransaction);
    //            _transactionService.AddTransaction(destinationTransaction);
    //        }
    //        else
    //        {
    //            throw new Exception("Insufficient funds or account(s) not found.");
    //        }
    //    }
    //}

}
