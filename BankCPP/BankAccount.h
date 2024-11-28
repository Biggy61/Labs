//
// Created by stepa on 11/20/2024.
//

#ifndef BANKACCOUNT_H
#define BANKACCOUNT_H
#include <string>
#include <iostream>
#include "BankAccount.h"
using namespace std;

class BankAccount
{
public:
    int AccountNumber;
    float Balance;
    string OwnerName;

    BankAccount(int account_number, float balance, string owner_name);
    void Deposit(float amount);
    void Withdraw(float amount);
    void Write();
};


#endif //BANKACCOUNT_H
