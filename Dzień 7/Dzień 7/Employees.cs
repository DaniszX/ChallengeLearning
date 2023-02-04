namespace Dzień_7
{
    public class Employee
    {
        public static string Grades = "Highest Grade";
        private List<float> grade = new List<float>();

        public Employee(float grade, string Name, string Surname, string Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            Grades = null;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }

        public float Grade
        {
            get
            {
                return this.grade.Sum();
            }
        }
        public void AddScore(int grade)
        {
            this.grade.Add(grade);
        }
        public void RemoveScore(int grade)
        {
            this.grade.Add(- grade);
        }

        public  Statistics GetStatistics()
        {
            var statistics = new Statistics();

            return statistics;
        }
    }
}

