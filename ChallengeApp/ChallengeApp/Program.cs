using System;

int[] grades = new int[5];
string[] dayOfWeek = new string[7];
dayOfWeek[0] = "Poniedziałek";
dayOfWeek[1] = "Wtorek";
dayOfWeek[2] = "Środa";
dayOfWeek[3] = "Czwartek";
dayOfWeek[4] = "Piątek";
dayOfWeek[5] = "Sobota";
dayOfWeek[6] = "Niedziela";

for (int i = 0; i < dayOfWeek.Length; i++)
{
    Console.WriteLine(dayOfWeek[i]);
}