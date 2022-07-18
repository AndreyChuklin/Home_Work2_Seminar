void Zadacha10()
{
    //10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    Random rand = new Random();
    int num = rand.Next(100, 999);
    Console.WriteLine("Случайное число");
    Console.WriteLine(num);

    int ones = num % 10;
    int tens = num / 10 % 10;
    int hand = num / 100;

    int ResultNum = tens;
    Console.WriteLine("Второе число в получившимся будет " + ResultNum);

}


void Zadacha13()
{
    //13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    
    
    
    Random rand = new Random();
    int num = rand.Next(1, 9999999);
    Console.WriteLine("Случайное число ");
    Console.WriteLine(num);

    if (num < 100)
    {
        Console.WriteLine ("вчисле менее трех символов");
    }
    else
    {
    while (num > 999)
    {
        num /= 10;
    }
    Console.WriteLine("Третье число " + num % 10);
    }

    

}


void Zadacha15()
{
//15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

    Console.WriteLine("Введите число дня недели ");
    int day = Convert.ToInt32(Console.ReadLine());
    
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Выходной");
    }
    else if (day >= 1 && day <= 5)
    {
        Console.WriteLine("Будни");
    }
    else
    {
        Console.WriteLine ("неккоретный ввод");
    }




   /* Console.WriteLine("Введите число дня недели "); //второй вариант решения
    int num = Convert.ToInt32(Console.ReadLine());

    if(num == 1) Console.WriteLine("Понедельник ");
    else if (num == 2) Console.WriteLine("Вторник ");
    else if (num == 3) Console.WriteLine("Среда ");
    else if (num == 4) Console.WriteLine("Четверг ");
    else if (num == 5) Console.WriteLine("Пятница ");
    else if (num == 6) Console.WriteLine("Суббота ");
    else if (num == 7) Console.WriteLine("Воскресенье");
    else Console.WriteLine("Введено число не дня недели "); */


}



//Zadacha10();
//Zadacha13();
//Zadacha15();