//
// Created by stepa on 11/28/2024.
//

#include "Employee.h"
#include <stddef.h>
#include <iostream>


Employee::Employee(string name, float yearly_salary, department department)
{
    Name = name;
    int words = 0;
    int lenOfSentence = name.size();
    for (int i = 0; i < lenOfSentence; i++)
    {if (name[i] == ' '){words++;}}
    words = words + 1;
    cout << "No. of words = " << words << endl;
    if (name.size() <= 0 || name.empty() || words <= 1)
    {
        throw new std::invalid_argument("Invalid Employee name");
    }

    YearlySalary = yearly_salary;
    Department = department;
}


float Employee::CalculateMonthlySalary()
{
    float monthly_salary = YearlySalary / 12;
    return monthly_salary;
}

void Employee::DisplayInformation()
{
    cout << "Name: " << Name << " Monthly salary: " << CalculateMonthlySalary() << " Department: " << Department <<
        endl;
}
