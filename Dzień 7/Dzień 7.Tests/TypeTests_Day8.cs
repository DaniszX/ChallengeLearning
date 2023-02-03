namespace Dzień_7.Tests
{
    public class TypeTests_Day8
    {
        [Test]
        public void GetGradeShouldReturnSameValue()
        {
            float Grade1 = 74564567;
            float Grade2 = 74564567;
            Assert.AreEqual(Grade1, Grade2);
        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            var emp1 = GetEmployee(0, "Anakin", "Skywalker", "22");
            var emp2 = GetEmployee(0, "Obi-Wan", "Kenobi", "38");
            Assert.AreNotEqual(emp1.Name, emp2.Name);
        }

        [Test]
        public void GetAgeShouldReturnDifferentValue()
        {
            int Age1 = 22;
            int Age2 = 38;
            Assert.AreNotEqual(Age1, Age2);
        }

        [Test]
        public void GetSurnameShouldReturnDifferentObjects()
        {
            string surname1 = "Skywalker";
            string surname2 = "Kenobi";
            Assert.AreNotEqual(surname1, surname2);
        }


        private Employee GetEmployee(int grade, string name, string surname, string age)
        {
            return new Employee(grade, name, surname, age);
        }
    }
}