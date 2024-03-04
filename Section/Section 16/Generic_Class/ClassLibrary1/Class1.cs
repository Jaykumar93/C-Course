
public class User<T1, T2>
{
    public T1 RegistrationStatus;

    public T2 age;
}

public abstract class Student
{
    public abstract int Marks { get; set; }
}
public class GraduateStudent:Student
{
    public override int Marks { get; set; }

}
public class PostGraduateStudent : Student
{
    public override int Marks { get; set; }

}


public class MarksPrinter<T>where T : Student
{
    public T stu;
    public void PrintMarks()
    {
        Student temp = (Student)stu;
        System.Console.WriteLine(temp);    
    }

}