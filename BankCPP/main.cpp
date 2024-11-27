#include <iostream>
#include <stdio.h>
#include "BankAccount.h"
#include "Transaction.h"
using namespace std;

int main()
{
    std::cout << "Hello, World!" << std::endl;
    BankAccount* blud = new BankAccount(001, 10, "Blud");
    BankAccount* Radek = new BankAccount(002, 120, "Radek");
    Transaction* transaction = new Transaction(*blud, *Radek, 20, "2024");
    transaction->Execute();
    cout << blud->AccountNumber << endl;
    cout << blud->OwnerName << endl;
    cout << blud->Balance << endl;
    cout << Radek->AccountNumber << endl;
    cout << Radek->OwnerName << endl;
    cout << Radek->Balance << endl;
    blud->Withdraw(10);
    Radek->Withdraw(10);
    blud->Deposit(20);
    Radek->Deposit(20);
    cout << blud->AccountNumber << endl;
    cout << blud->OwnerName << endl;
    cout << blud->Balance << endl;
    cout << Radek->AccountNumber << endl;
    cout << Radek->OwnerName << endl;
    cout << Radek->Balance << endl;
    return 0;
}
