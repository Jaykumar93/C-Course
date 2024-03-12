using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
public class AppDbContext : DbContext
{
    public DbSet<Author> YourEntities { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=BookStore;User=root;Password=root;");
    }
}
public class Author
{
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }
   
    // Add more properties as needed
}


class Program
{
    static void Main()
    {
        using (var dbContext = new AppDbContext())
        {
            // LINQ query example
            var query = from entity in dbContext.YourEntities
                        where entity.AuthorName == "Harper Lee"
                        select entity;
            // Execute the query
            var results = query.ToList();
            // Process the results
            foreach (var result in results)
            {
                Console.WriteLine($"Id: {result.AuthorName}, Column1: {result.AuthorId}");
            }
        }
    }
}