namespace StaffAdministrationCsharp;

public class Employee
{
    public string Name;
    public decimal YearlySalary;
    public Department Department;
    public int Words;
    
    
    public Employee(string name, decimal yearlySalary, Department department)
    {
        Name = name;
        if (name == null || name == String.Empty) { throw new ArgumentException("Name cannot be empty"); }
        Words = name.Split(' ').Length;
        if (Words < 2) { throw new ArgumentException("Write Name and Surname"); }
        YearlySalary = yearlySalary;
        Department = department;
        CompanyDepartment(false);
    }


    public decimal CalculateMonthlySalary()
    {
        decimal monthlySalary = YearlySalary / 12;
        return monthlySalary;
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"Name: {Name}, Monthly salary: {CalculateMonthlySalary()}, Department: {Department}");
    }

    public void CompanyDepartment(bool boss)
    {
        if (boss) { Department = Department.Company; }
        else if (!boss)
        {
            if (Department == Department.Company)
            {
                throw new ArgumentException("Only boss can have company department");
            }
        }
    }

}