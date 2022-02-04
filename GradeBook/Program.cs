
namespace GradeBook;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("Math GradeBook");
        book.AddGrade(12.4);
        book.AddGrade(9.7);
        book.AddGrade(15.2);
        book.AddGrade(56.1);
        book.AddGrade(77.0);

        Statistics results = book.GetStatistics();

        Console.WriteLine($"The lowest grade in the book is {results.Lowest}");
        Console.WriteLine($"The highest grade in the book is {results.Highest}");
        Console.WriteLine($"The average grade for the book is {results.Average}");
    }
}