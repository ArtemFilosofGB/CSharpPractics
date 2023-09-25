// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.



int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Quater(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0; //x ==0 y == 0

}


int xCoordinate = GetUserInput("Ведите х:");
int yCoordinate = GetUserInput("Ведите y:");
int quater = Quater(xCoordinate, yCoordinate);

string result = quater > 0
                ? $"Указаные коордитаты соотвествуюи четверти {quater}"
                : $"Введены некоректные координаты";
Console.WriteLine(result);