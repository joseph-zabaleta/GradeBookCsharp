namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;
        /// <summary>
        /// Gradebook's constructor that takes in a string for the name of the gradebook.
        /// </summary>
        /// <param name="name">Gradebook's name</param>
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        /// <summary>
        /// Add a grade to the gradebook
        /// </summary>
        /// <param name="grade">Grade to add</param>
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        /// <summary>
        /// Calculates the average grade in the gradebook
        /// </summary>
        /// <returns>A double value representing the average</returns>
        public double GetAverage()
        {
            return grades.Average();
        }

        /// <summary>
        /// Finds the lowest value in the gradebook
        /// </summary>
        /// <returns>A double value representing the lowest value</returns>
        public double GetLowestGrade()
        {
            return grades.Min();
        }

        /// <summary>
        /// Finds the highest value in the gradebook
        /// </summary>
        /// <returns>A double value representing the highest value</returns>
        public double GetHighestGrade()
        {
            return grades.Max();
        }

        public Statistics GetStatistics()
        {

            Statistics results = new Statistics();

            results.Average = this.GetAverage();
            results.Lowest = this.GetLowestGrade();
            results.Highest = this.GetHighestGrade();

            return results;
        }
    }
}
