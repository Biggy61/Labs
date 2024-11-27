//
// Created by stepa on 11/25/2024.
//

#include "Transaction.h"
#include "BankAccount.h"

Transaction::Transaction(BankAccount fromAccount, BankAccount toAccount, float amount, string date)
{
    this->fromAccount = fromAccount;
    this->toAccount = toAccount;
    this->amount = amount;
    this->date = date;
}

void Transaction::Execute()
{
    fromAccount.Balance -= amount;
    toAccount.Balance += amount;
}
