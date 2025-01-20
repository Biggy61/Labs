//
// Created by stepa on 1/20/2025.
//

#include "Boss.h"
#include <iostream>

Boss::Boss(string name, float yearly_salary, department department, float bonus, float stockOptions) : Manager(name, yearly_salary, department, bonus)
{
 StockOptions = stockOptions;
}

float Boss::CalculateMonthlySalary()
{
    float monthly_salary = (YearlySalary + Bonus + StockOptions) / 12 ;
    return monthly_salary;
}

void Boss::DisplayInformation()
{

    cout << "Name: " << Name << " Monthly salary: " << CalculateMonthlySalary() << " Department: " << Department << endl;
}