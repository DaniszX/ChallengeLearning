using Employees;

namespace StatTest
{
    public class Tests
    {
        [Test]
        public void CheckStats()
        {
            //arrange
            var employee1 = new Employee("Anakin", "Skywalker");
            employee1.AddGrade(5);
            employee1.AddGrade(8);
            employee1.AddGrade(2);
            var statistics1 = employee1.GetStatistics();
            Console.WriteLine($"Average : {statistics1.Average:N2}");
            Console.WriteLine($"Max : {statistics1.Max}");
            Console.WriteLine($"Min : {statistics1.Min}");
            //act

            //assert

            Assert.AreEqual(statistics1.Max, 8);
            Assert.AreEqual(statistics1.Min, 2);
            Assert.AreEqual(statistics1.Average, 5);
            Assert.AreNotEqual(statistics1.Average, statistics1.Min);
            Assert.AreNotEqual(statistics1.Max, statistics1.Min);

        }
    }
}