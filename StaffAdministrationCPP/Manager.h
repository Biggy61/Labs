//
// Created by stepa on 11/28/2024.
//

#ifndef MANAGER_H
#define MANAGER_H
#include "Employee.h"

class Manager : public Employee{
  public:
   float Bonus;
    Manager(string name, float yearly_salary,department department, float bonus);
    float CalculateMonthlySalary();
    void DisplayInformation();

};


#endif //MANAGER_H
