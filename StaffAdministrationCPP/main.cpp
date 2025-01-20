#include <iostream>

#include "Boss.h"
#include "Employee.h"
#include "Manager.h"
int main()
{
    std::cout << "Hello, World!" << std::endl;
    Employee pavel("Pavel Lukas", 1200, Employee::Programmer);
    pavel.DisplayInformation();
    Manager radek("Radek Pelikan", 1200, Manager::ItSupport, 120);
    radek.DisplayInformation();
    Boss bohata("Vaclav Bohata", 1200, Boss::Company, 120, 120);
    bohata.DisplayInformation();
    return 0;
}
