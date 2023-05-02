// task1.
//На вход  принимаем два числа, 
//на выходе показывает вторую цифру




// int Prompt(string message) 
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine(); //выводим переменную
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int number = Prompt("Введите трехзначное число >");
// if (number < 100 || number >= 1000)
// {
//     Console.WriteLine("Вы ввели не трехзанчное число,повторите попытку");
//     return;
// }

// Console.WriteLine($"Введите число {number}");
// int secondRank = number / 10 % 10;
// Console.WriteLine($"Вторая цифра {secondRank}");


// task2.
//Программа вводит третью цифру числа, или сообщает, 
//что ее нет

// int Prompt(string messege)
// {

//     Console.WriteLine(messege);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int GetThirdRank(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }

// bool  ValidateNumber(int number)
// {
//     if (number<100)
//     {   
//         Console.WriteLine("Третей цифры нет");
//         return false;
//     }
//     return true;
// }
// int number = Prompt("Введите число:");
// if (ValidateNumber(number))
// {
//     Console.WriteLine(GetThirdRank(number));
// }

//task3.
//Программа принимает число и выдает какой 
//сегодня день недели

int Prompt(string messege)
{
    Console.Write(messege);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}
int weekDay = Prompt("введите день недели>");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Наконец-то выходной");
    }
    else
    {
        Console.WriteLine("нужо еще поработать");
    }
}

