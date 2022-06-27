int number = new Random().Next(100, 1000);
int digitTwo = (number % 100)/10;
Console.WriteLine($"Вторая цифра числа {number} - {digitTwo}");