using Stats;

namespace Employees
{
    public class Employee
    {
        public static string Grades = "Highest Grade";
        private List<float> grades = new List<float>();

        public Employee(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
            
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }


        public float Grade
        {
            get
            {
                return this.grades.Sum();
            }
        }
        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue ;
            statistics.Min = float.MaxValue;


            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}

