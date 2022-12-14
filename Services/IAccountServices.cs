using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Services
{
    public interface IAccountServices
    {
        void CreateAccount(string accountName, AccountType accountType);
        decimal GetAccountBalance(string accountName);
        int GetRewardPoints(string accountName);
        void Deposit(string accountName, decimal amount);
        void Withdrawal(string accountName, decimal amount);
    }
}
