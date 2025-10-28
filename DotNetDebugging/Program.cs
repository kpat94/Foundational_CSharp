﻿using System.Diagnostics;

int result = Fibonacci(6);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    Debug.WriteLine($"Entering the {nameof(Fibonacci)} method.");
    Debug.WriteLine($"Tring to find the {n}th number in the sequence.");

    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;

        Debug.WriteLineIf(sum == 1, $"Sum is 1. n1 is {n1} and n2 is {n2}");
    }

    Debug.Assert(n2 == 5, $"Expected value 5. Found {n2}");
    return n == 0 ? n1 : n2;
}