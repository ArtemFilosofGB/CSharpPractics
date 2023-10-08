// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[] Intersection(double k1, double b1, double k2, double b2)
{
    
    double[] arr = new double[2];//arr[0] == x; arr[1] == y
    arr[0] = (b2-b1)/(k1-k2);
    arr[1] = k1 * arr[0] + b1; 
    return arr;
}


Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");
double k1 = GetUserInput("Введите k1:");
double b1 = GetUserInput("Введите b1:");
double k2 = GetUserInput("Введите k2:");
double b2 = GetUserInput("Введите b2:");
double[] intersection = Intersection(k1,b1,k2,b2);
Console.WriteLine($"Пересечение в ({intersection[0]:F1}:{intersection[1]:F1})");

