//
// Created by stepa on 11/28/2024.
//

#include "Manager.h"

#include <iostream>

Manager::Manager(string name, float yearly_salary,string department, float bonus) : Employee(name,yearly_salary,department)
{
    Bonus = bonus;
}

float Manager::CalculateMonthlySalary()
{
    float monthly_salary = (YearlySalary+ Bonus) / 12 ;
    return monthly_salary;
}

void Manager::DisplayInformation()
{

    cout << "Name: " << Name << " Monthly salary: " << CalculateMonthlySalary() << " Department: " << Department << endl;
}


