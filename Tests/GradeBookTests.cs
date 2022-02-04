using Xunit;

namespace GradeBook.Tests
{
    public class GradeBookTests
    {
        [Fact]
        public void Test1()
        {
            Book book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            Statistics stats = book.GetStatistics();

            Assert.Equal(85.6, stats.Average, 1);
            Assert.Equal(77.3, stats.Lowest);
            Assert.Equal(90.5, stats.Highest);
        }
    }
}