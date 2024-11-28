//
// Created by stepa on 11/25/2024.
//

#include "Transaction.h"
#include "BankAccount.h"

Transaction::Transaction(BankAccount fromAccount, BankAccount toAccount, float amount, string date): FromAccount(fromAccount),
    ToAccount(ToAccount)
{

    FromAccount = fromAccount;
    ToAccount = toAccount;
    this->amount = amount;
    this->date = date;

}
void Transaction::Execute()
{
    FromAccount.Balance -= amount;
    ToAccount.Balance += amount;
}

