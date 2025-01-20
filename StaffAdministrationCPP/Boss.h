//
// Created by stepa on 1/20/2025.
//

#ifndef BOSS_H
#define BOSS_H
#include "Manager.h"


class Boss : public Manager{
 public:
  float StockOptions;
    Boss(string name, float yearly_salary,department department, float bonus, float StockOptions);
    float CalculateMonthlySalary();
    void DisplayInformation();
};



#endif //BOSS_H
