//
// Created by stepa on 11/28/2024.
//

#include "Employee.h"

#include <iostream>


Employee::Employee(string name, float yearly_salary, string department)
{
    Name = name;
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

    cout << "Name: " << Name << " Monthly salary: " << CalculateMonthlySalary() << " Department: " << Department << endl;
}
