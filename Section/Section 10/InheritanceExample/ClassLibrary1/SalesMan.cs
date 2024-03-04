public class SalesMan : Employee
{
    private string _region;

    public SalesMan(int empID,string empName,string location, string region):base(empID, empName, region)
    {
        this._region = region;
    }
    public string Region
    {
        set { _region = value; }
        get { return _region; }
    }

    public long GetSalesOfTheCurrentMonth()
    {
        return 1242;
    }
    
    // Here i have created a methods where i have accessed the location from the parent class using the base keyword 
   // IT IS MAINLY USED WHEN YOU HAVE SAME NAME FIELD IN BOTH CHILD AND PARENT CLASS        
    public string GetCompleteLocation()
    {
        return base.Location + Region;
    }
}