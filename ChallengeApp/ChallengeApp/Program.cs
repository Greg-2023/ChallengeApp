string name = "Ewa";
string sex = "F";
var age = 33;


if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
    Console.WriteLine();
    Console.WriteLine();
}
else if (sex == "F" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (sex == "M" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}