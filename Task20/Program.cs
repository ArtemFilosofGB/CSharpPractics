// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double Distanse(int xa, int ya, int xb, int yb)
{   // // d = √((хА –  хВ)2 + (уА – уВ)2)
    double res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow((yb - ya), 2));
   
    Console.WriteLine(res);
    return res;
}

int x1 = GetUserInput("Imput x1");
int y1 = GetUserInput("Imput y1");
int x2 = GetUserInput("Imput x2");
int y2 = GetUserInput("Imput y2");
double result = Distanse(x1, y1, x2, y2);
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero)); // округление






