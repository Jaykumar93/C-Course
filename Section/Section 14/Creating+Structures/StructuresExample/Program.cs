using System;

class Program
{
    static void Main()
    {
        //create structure instance its not like we are creating an object
        Category category = new Category();

        //initialize fields through properties
        category.CategoryID = 21;
        category.CategoryName = "jaykumar";

        //access methods
        Console.WriteLine(category.CategoryID);
        Console.WriteLine(category.CategoryName);
        Console.WriteLine(category.GetCategoryNameLength());

        Console.ReadKey();
    }
}