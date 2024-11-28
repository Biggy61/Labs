#include <iostream>
#include "Employee.h"
#include "Manager.h"
int main()
{
    std::cout << "Hello, World!" << std::endl;
    Employee pavel("Pavel", 1200, "IT");
    pavel.DisplayInformation();
    Manager radek("Radek", 1200, "IT", 120);
    radek.DisplayInformation();
    return 0;
}
test