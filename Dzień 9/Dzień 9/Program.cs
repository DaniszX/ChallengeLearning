using Employees;
using Stats;

var employee1 = new Employee("Anakin", "Skywalker");
employee1.AddGrade(4);
employee1.AddGrade(7);
employee1.AddGrade(2);
var statistics1 = employee1.GetStatistics();
Console.WriteLine($"Average : {statistics1.Average:N2}");
Console.WriteLine($"Max : {statistics1.Max}");
Console.WriteLine($"Min : {statistics1.Min}");

SetSth(ref statistics1);
void SetSth(ref Statistics statistics1)
{
    statistics1 = new Statistics();
}

