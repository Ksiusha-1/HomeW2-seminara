// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите  число: ");
int num = int.Parse(Console.ReadLine()!);
if (num == 3 || num > 3)
{
    Console.WriteLine($"{num % 10}");
    Console.WriteLine($"{num % 10000 % 1000 / 100}");

}
else if (num < 3)
{
    Console.WriteLine($"{num % 10} :третьей цифры нет");
}


//else if (num > 3)
//{
//Console.WriteLine($"{num % 10000 % 1000 / 100}");
//}