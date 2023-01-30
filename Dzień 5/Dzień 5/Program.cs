var number = 456612421;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

List<int> Count = new List<int>();
Count.Add(0);
Count.Add(1);
Count.Add(2);
Count.Add(3);
Count.Add(4);
Count.Add(5);
Count.Add(6);
Count.Add(7);
Count.Add(8);
Count.Add(9);

Count[0] = 0;
Count[1] = 0;
Count[2] = 0;
Count[3] = 0;
Count[4] = 0;
Count[5] = 0;
Count[6] = 0;
Count[7] = 0;
Count[8] = 0;
Count[9] = 0;
foreach (var Numb in letters)
{
    if (Numb == '0')
    {
        Count[0]++;
    }
    else if (Numb == '1')
    {
        Count[1]++;
    }
    else if (Numb == '2')
    {
        Count[2]++;
    }
    else if (Numb == '3')
    {
        Count[3]++;
    }
    else if (Numb == '4')
    {
        Count[4]++;
    }
    else if (Numb == '5')
    {
        Count[5]++;
    }
    else if (Numb == '6')
    {
        Count[6]++;
    }
    else if (Numb == '7')
    {
        Count[7]++;
    }
    else if (Numb == '8')
    {
        Count[8]++;
    }
    else if (Numb == '9')
    {
        Count[9]++;
    }
}

Console.WriteLine("0=> " + Count[0]);
Console.WriteLine("1=> " + Count[1]);
Console.WriteLine("2=> " + Count[2]);
Console.WriteLine("3=> " + Count[3]);
Console.WriteLine("4=> " + Count[4]);
Console.WriteLine("5=> " + Count[5]);
Console.WriteLine("6=> " + Count[6]);
Console.WriteLine("7=> " + Count[7]);
Console.WriteLine("8=> " + Count[8]);
Console.WriteLine("9=> " + Count[9]);







/*int[] grades = new int[5];
string[] dayOfWeeks = new string[7];*/

//Console.WriteLine(dayOfWeeks[2]);
// przy tych
// używać w pętli dayOfWeeks.COUNT
//string[] dayOfWeeks2 = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
//Console.WriteLine(dayOfWeeks2[1]);

//lepsza lista
/*List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add ("Monday");
dayOfWeeks.Add ("Tuesday");
dayOfWeeks.Add ("Wednesday");
dayOfWeeks.Add ("Thursday");
dayOfWeeks.Add ("Friday");
dayOfWeeks.Add ("Saturday");
dayOfWeeks.Add ("Sunday");
for (int i = 0; i < dayOfWeeks.Count; i++)
{
    Console.WriteLine(dayOfWeeks[i]);
}

Console.WriteLine();

foreach (var day in dayOfWeeks)
{
    Console.WriteLine(day);
}*/