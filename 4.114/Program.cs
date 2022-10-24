  Console.Write("Введите год"); 
            int yearY = int.Parse(Console.ReadLine()); 
 
            Console.Write("Введите номер месяца"); 
            int mounth = int.Parse(Console.ReadLine()); 
 
            Console.Write("Введите день"); 
            int day = int.Parse(Console.ReadLine()); 
 
            Console.WriteLine($"Дата предыдущего дня {day - 1}.{mounth}.{yearY}"); 
            Console.WriteLine($"Дата следующего дня {day + 1}.{mounth}.{yearY}");

if (yearY % 4 == 0 && (yearY % 100 != 0 || yearY % 400 == 0))
{
    Console.WriteLine("Год високосный");
}
else
{
    Console.WriteLine("Год не високосный");
}