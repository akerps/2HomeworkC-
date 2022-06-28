Console.WriteLine("Введите число от 1 до 7");
int weeknumber = Convert.ToInt32(Console.ReadLine());
if (weeknumber <= 5 & weeknumber >= 1)
{
    Console.WriteLine("нет");
}
else if (weeknumber == 6 || weeknumber == 7)
{
    Console.WriteLine("да");
}