using System.Reflection.Metadata;

namespace Dzień_7.Tests

{
    public class Tests
    {
        [Test]
        public void CheckSumOp()
        {
            // arrange
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;
            var employee1 = new Employee(sum1 ,"Anakin", "Skywalker", "23");
            employee1.AddScore(4);
            employee1.AddScore(7);
            employee1.RemoveScore(20);
            // act
            var result1 = employee1.Grade;
            // assert
            Assert.AreEqual(-9, result1);

            var employee2 = new Employee(sum2, "Obi-Wan", "Kenobi", "38");
            employee2.AddScore(5);
            employee2.AddScore(6);
            employee2.RemoveScore(2);
            
            var result2 = employee2.Grade;
            
            Assert.AreEqual(9, result2);

            var employee3 = new Employee(sum3, "Padme", "Amidala", "27");
            employee3.AddScore(9);
            employee3.AddScore(8);
            employee3.RemoveScore(17);
            
            var result3 = employee3.Grade;
            
            Assert.AreEqual(0, result3);
        }
    }
}