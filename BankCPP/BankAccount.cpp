#include "BankAccount.h"

BankAccount::BankAccount(int account_number, float balance, string owner_name)
{
    AccountNumber = account_number;
    Balance = balance;
    OwnerName = owner_name;
}


void BankAccount::Deposit(float amount)
{
    Balance += amount;
    cout << "Balance: " << Balance << endl;
}
void  BankAccount::Withdraw(float amount)
{
    Balance -= amount;
    cout << "Balance: " << Balance << endl;
}

void BankAccount::Write()
{
    cout << "AccountNumber: " << AccountNumber << " OwnerName: " << OwnerName  << " Balance: " << Balance << endl;
}


