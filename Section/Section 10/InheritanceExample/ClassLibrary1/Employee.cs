public class Employee
{
    private int _empId;
    private string _empName;
    private string _location;

    public Employee(int EmpID,string EmpName, string Location)
    {
        this._empName = EmpName;
        this._empId = EmpID;    
        this.Location = Location;
    }

    public int EmpID
    {
        set
        {
            _empId = value;
        }
        get
        {
            return _empId;
        }
    }
    public string EmpName
    {
        set
        {
            _empName = value;
        }
        get
        {
            return _empName;
        }
    }
    public string Location
    {
        set
        {
            _location = value;
        }
        get
        {
            return _location;
        }
    }

}