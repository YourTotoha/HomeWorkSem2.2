//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

void Distance3d(double NumX1, double NumY1,
                double NumZ1, double NumX2,
                double NumY2, double NumZ2)
{
    double SquareNumX = Math.Pow(NumX1 - NumX2, 2);
    double SquareNumY = Math.Pow(NumY1 - NumY2, 2);
    double SquareNumZ = Math.Pow(NumZ1 - NumZ2, 2);
    Console.WriteLine(Math.Sqrt(SquareNumX + SquareNumY + SquareNumZ));
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int Number = int.Parse(Console.ReadLine());
    return (Number);
}

int NumX1 = GetNum("Введите часть координаты первой точки, X: ");
int NumY1 = GetNum("Введите часть координаты первой точки, Y: ");
int NumZ1 = GetNum("Введите часть координаты первой точки, Z: ");

int NumX2 = GetNum("Введите часть координаты второй точки, X: ");
int NumY2 = GetNum("Введите часть координаты второй точки, Y: ");
int NumZ2 = GetNum("Введите часть координаты второй точки, Z: ");

Distance3d(NumX1, NumY1, NumZ1, NumX2, NumY2, NumZ2);