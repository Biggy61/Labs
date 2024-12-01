namespace StaffAdministrationCsharp;

public class Boss : Manager
{
    public decimal StockOptions;

    public Boss(string name, decimal yearlySalary, Department department, decimal bonus, decimal stockOptions) : base(name, yearlySalary, department,  bonus)
    {
        StockOptions = stockOptions;
        CompanyDepartment(true);
    }

    public decimal CalculateMonthlySalary()
    {
        decimal monthlySalary = (YearlySalary + Bonus + StockOptions) / 12;
        return monthlySalary;
    }
    
    public void DisplayInformation()
    {
        Console.WriteLine($"Name: {Name}, Monthly salary: {CalculateMonthlySalary()}, Department: {Department}");
    }
    
    public void CompanyDepartment(bool boss)
    {
        if (boss) { Department = Department.Company; }
    }
}