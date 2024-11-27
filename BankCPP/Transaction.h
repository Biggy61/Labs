//
// Created by stepa on 11/25/2024.
//

#ifndef TRANSACTION_H
#define TRANSACTION_H
#include "BankAccount.h"


class Transaction
{
public:
    BankAccount fromAccount;
    BankAccount toAccount;
    float amount;
    string date;

    Transaction(BankAccount fromAccount, BankAccount toAccount, float amount, string date);
    void Execute();
};



#endif //TRANSACTION_H
