//
// Created by stepa on 11/20/2024.
//

#ifndef BANKACCOUNT_H
#define BANKACCOUNT_H
#include <string>
#include <iostream>
using namespace std;

class BankAccount
{
public:
    int AccountNumber;
    float Balance;
    string OwnerName;

    BankAccount(int account_number, float balance, string owner_name);
    BankAccount();
    void Deposit(float amount);
    void Withdraw(float amount);

};


#endif //BANKACCOUNT_H
