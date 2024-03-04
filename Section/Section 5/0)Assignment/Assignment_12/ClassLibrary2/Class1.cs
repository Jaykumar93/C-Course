public class Employee
{
    public uint EmployeeID;
    public string EmployeeName;
    public double SalaryPerHour;
    public double NoOfWorkingHours;
    public double NetSalary;

    public static string OrganizationName = "Harsh Inc.";

    public const string TypeOfEmployee = "Contract Based";

    public readonly string DepartmentName;

    public Employee()
    {
        DepartmentName = "Finance Department";
    }
}

