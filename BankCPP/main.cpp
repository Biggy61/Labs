#include <iostream>
#include <stdio.h>
#include "BankAccount.h"
#include "Transaction.h"
using namespace std;

int main()
{
    std::cout << "Hello, World!" << std::endl;
    BankAccount blud(001, 100, "Blud");
    BankAccount Radek(002, 120, "Radek");
    blud.Write();
    Radek.Write();
    Transaction transaction(blud, Radek, 20, "2024");
    transaction.Execute();
    blud.Write();
    Radek.Write();
    // blud.Withdraw(10);
    // Radek.Withdraw(10);
    // blud.Deposit(20);
    // Radek.Deposit(20);
    // blud.Write();
    // Radek.Write();
    return 0;
}
