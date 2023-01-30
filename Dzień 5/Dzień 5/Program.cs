var number = 78235667;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int Count0 = 0;
int Count1 = 0; 
int Count2 = 0; 
int Count3 = 0;
int Count4 = 0;
int Count5 = 0;
int Count6 = 0;
int Count7 = 0;
int Count8 = 0;
int Count9 = 0;
foreach (var Numb in letters)
{
    if (Numb == '0')
    {
        Count0++;
    }
    else if (Numb == '1')
    {
        Count1++;
    }
    else if (Numb == '2')
    {
        Count2++;
    }
    else if (Numb == '3')
    {
        Count3++;
    }
    else if (Numb == '4')
    {
        Count4++;
    }
    else if (Numb == '5')
    {
        Count5++;
    }
    else if (Numb == '6')
    {
        Count6++;
    }
    else if (Numb == '7')
    {
        Count7++;
    }
    else if (Numb == '8')
    {
        Count8++;
    }
    else if (Numb == '9')
    {
        Count9++;
    }
}

Console.WriteLine("0=> " + Count0);
Console.WriteLine("1=> " + Count1);
Console.WriteLine("2=> " + Count2);
Console.WriteLine("3=> " + Count3);
Console.WriteLine("4=> " + Count4);
Console.WriteLine("5=> " + Count5);
Console.WriteLine("6=> " + Count6);
Console.WriteLine("7=> " + Count7);
Console.WriteLine("8=> " + Count8);
Console.WriteLine("9=> " + Count9);

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