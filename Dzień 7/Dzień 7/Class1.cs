namespace Dzień_7
{
    public class Employee
    {
        public static string Grades = "Highest Grade";
        private List<int> grade = new List<int>();

        public Employee(int grade, string Name, string Surname, string Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            Grades = null;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }

        public int Grade
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
    }
}

