using Dzień_7;

var sum1 = 0;
var sum2 = 0;
var sum3 = 0;
Employee number1 = new Employee(sum1, "Anakin", "Skywalker", "22");
Employee number2 = new Employee(sum2, "Obi-Wan", "Kenobi", "38");
Employee number3 = new Employee(sum3, "Padme", "Amidala", "27");

number1.AddScore(5);
number1.AddScore(7);
number1.AddScore(2);
number1.AddScore(4);
number1.AddScore(6);

number2.AddScore(9);
number2.AddScore(6);
number2.AddScore(7);
number2.AddScore(5);
number2.AddScore(4);

number3.AddScore(4);
number3.AddScore(5);
number3.AddScore(5);
number3.AddScore(7);
number3.AddScore(9);

sum1 = number1.Grade;
sum2 = number2.Grade;
sum3 = number3.Grade;

int[] result = new int[] { sum1, sum2, sum3 };
int maxResult = result.Max();

List<Employee> employees = new List<Employee>()
{
    number1, number2, number3
};

Employee employeeWithHighestGrade = null;

foreach (var employee in employees)
{
    if (employee.Grade == maxResult)
    {
        employeeWithHighestGrade = employee;
    }
}

Console.WriteLine($"{employeeWithHighestGrade.Name} {employeeWithHighestGrade.Surname} is currently the best employee with the score of {employeeWithHighestGrade.Grade}.");