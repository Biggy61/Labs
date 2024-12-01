namespace StaffAdministrationCsharp;

public class Manager : Employee
{
    public decimal Bonus;

    public Manager(string name, decimal yearlySalary, Department department, decimal bonus) : base(name, yearlySalary, department)
    {
        Bonus = bonus;
    }

    public decimal CalculateMonthlySalary()
    {
        decimal monthlySalary = (YearlySalary + Bonus) / 12;
        return monthlySalary;
    }
    
    public void DisplayInformation()
    {
        Console.WriteLine($"Name: {Name}, Monthly salary: {CalculateMonthlySalary()}, Department: {Department}");
    }
}