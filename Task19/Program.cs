//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
void Polydrome(int Num)
{
    //Определяем значение цифр в пятизначном числе
    int FirstNum = Num / 10000;
    int LastNum = Num % 10;
    int SecondNum = (Num / 1000) % 10;
    int PreLastNum = (Num / 10) % 10;
    if (FirstNum == LastNum & SecondNum == PreLastNum)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int Number = int.Parse(Console.ReadLine());
    return (Number);
}

int Num = GetNum("Введите пятизначное число: ");

Polydrome(Num);