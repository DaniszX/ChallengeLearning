var imie = "Ewa";
var wiek = 33;
var płeć = "Kobieta";

if (wiek < 30 && wiek >= 18)
{
    if (płeć == "Kobieta")
    {
        Console.WriteLine("Kobieta poniżej 30-tki.");
    }
    else
    {
        Console.WriteLine("Mężczyzna poniżej 30-tki.");
    }
}
else if (wiek > 30)
{
    if (płeć == "Kobieta")
    {
        if (imie == "Ewa" && wiek == 33)
        {
            Console.WriteLine("Ewa, lat 33.");
        }
        else
        {
            Console.WriteLine("Kobieta po 30-tce.");
        }
    }
    else
    {
        Console.WriteLine("Mężczyzna po 30-tce.");
    }
}
else if (wiek < 18)
{
    if (płeć == "Kobieta")
    {
        Console.WriteLine("Niepełnoletnia dziewczyna.");
    }
    else
    {
        Console.WriteLine("Niepełnoletni chłopak.");
    }
}






// praca podczas kursu

/*var name = "Rafał";
var age = 27;
if (age >= 50)
{
    if (name == "Rafał")
    {
        Console.WriteLine("Jestem Rafałem, i jestem staruchem");
    }
    else
    {
        Console.WriteLine("Nie jestem Rafałem i jestem staruchem");
    }
}
else if (age >= 30 && age < 50)
{
    if (name == "Rafał")
    {
        Console.WriteLine("Jestem Rafałem już po 30-stce");
    }
    else
    {
        Console.WriteLine("Jestem kimś innym po 30-stce");
    }
}
else if (age < 30)
{
    if (name == "Rafał")
    {
        Console.WriteLine("Jestem Rafałem przed 30-stką");
    }
    else
    {
        Console.WriteLine("Jestem kimś innym przed 30-stką");
    }
}*/

//notatki dla mnie

// liczby całkowite
/*var myAge = 27;
int newAge = myAge + 1;
int myVar = int.MinValue;
ulong muVar3 = ulong.MaxValue;

//liczby zmiennoprzecinkowe
float myNum = float.MaxValue;
double myNum2 = double.MaxValue;

// zmienne tekstowe
string name2 = "Rafał ";
string surname = "Daniszewski ";
string result = name2 + surname + myNum2;
Console.WriteLine(result);
char myVar0 = 'c'; //przechowuje tylko pojedynczą wartość
var res2 = name.ToArray(); // jak dokładnie to działa?
Console.WriteLine(res2);

// zmienna logiczna
bool isActive = true;
isActive = false;
var isValid = 5 > 7;
Console.WriteLine(isValid);*/

//operatory
// == - takie same
// != różne

// operator logiczne
// && - 'i'
// || - 'lub'
// ! - negacja całej operacji np. [ !(age<50) ] - czy age nie jest mniejszy od 50