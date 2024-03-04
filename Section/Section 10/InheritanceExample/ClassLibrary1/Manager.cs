
public class Manager : Employee
{
    private string _departmentName;

    public Manager(int empID,string empName,string location, string departmentName):base(empID,empName,location)
    {
        departmentName = departmentName;
    }
    public string DepartmentName
    {
        set 
        { 
            this._departmentName = value;
        }
        get 
        {
            return this._departmentName;
        }
    }
    

    //creating a method of get total sales of the year

    public long GetTotalSalesOfTheYear()
    {
        return 10000;
    }
}