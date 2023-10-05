// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool IsExistTriangle(int a, int b, int c)
{
    if(a< b+c && b< a+c && c<a+b) return true;
    else return false;
}


int aTriang =GetUserInput("Введите а");
int bTriang =GetUserInput("Введите b");
int cTriang =GetUserInput("Введите c");
bool isExistTriangle= IsExistTriangle(aTriang, bTriang, cTriang);
if (isExistTriangle) Console.WriteLine("Да");
else Console.WriteLine("Нет");