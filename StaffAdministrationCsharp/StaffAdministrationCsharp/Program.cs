using System;

namespace StaffAdministrationCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Pavel = new Employee("Pavel Lukasek", 12000, Department.ItSupport );
            Pavel.DisplayInformation();
            Manager Radek = new Manager("Radek Zdarsky", 12000, Department.Programmer, 1200);
            Radek.DisplayInformation();
            Boss Bohata = new Boss("Vaclav Bohata", 12000, Department.Company, 1200, 1200);
            Bohata.DisplayInformation();
        }
    }
}

