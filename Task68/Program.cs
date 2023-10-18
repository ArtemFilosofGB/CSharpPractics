// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));

    //rerturn (m == 0)? n +1 :
    //        (n == 0) ? Ackermann(m - 1, 1) :
    //                    Ackermann(m - 1, Ackermann(m, n - 1));
}

for (int m = 0; m <= 5; m++)
{
    for (int n = 0; n <= 5; n++)
    {
        int result = Ackermann(m, n);
        Console.WriteLine($"Ackermann({m}, {n}) = {result}");
    }
    Console.WriteLine();
}

// Ackermann(3, 4) = 125
// Ackermann(3, 5) = 253
//Ackermann(4, 0) = 13
// Stack overflow.

