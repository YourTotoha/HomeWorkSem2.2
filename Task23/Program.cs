//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeNum(int Num)
{
    int Count = 1;
    while (Count < Num)
    {
        Console.Write(Math.Pow(Count, 3) + ", ");
        Count++;
    }
    //данная строка нужна чтобы на конце списка кубов числа N не было запятой (так выглядит аккуратнее)
    Console.Write(Math.Pow(Count, 3));

}

int GetNum(string text)
{
    Console.WriteLine(text);
    int Number = int.Parse(Console.ReadLine());
    return (Number);
}

int Num = GetNum("Введите значение N: ");

CubeNum(Num);