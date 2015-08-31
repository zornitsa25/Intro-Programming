using System;

class Sunglasses
{
    static void Asterisks()
    {
        Console.Write('*');
    }
    static void Space()
    {
        Console.Write(' ');
    }

    static void FirstLastRow(int n)
    {
        int Ast = 2 * n;
        for (int i = 0; i < Ast; i++)
        {
            Asterisks();
        }
        for(int i=0;i<n;i++)
        {
            Space();
        }
        for (int i = 0; i < Ast; i++)
        {
            Asterisks();
        }
        Console.WriteLine();
    }
    static void Middle(int n)
    {
        char ast = '*';

        for (int i = 0; i < n-2;i++)
        {
            Console.Write(ast);
            for (int j = 0; j < 2 * n - 2; j++)
            {
                Console.Write('/');
            }
            Console.Write(ast);
            if(i==(n-3)/2)
            {
                for (int k = 0; k < n;k++)
                    Console.Write('|');
            }
            else
            {
                for (int p = 0; p < n; p++)
                {
                    Space();
                }
            }
            Console.Write(ast);
            for (int j = 0; j < 2 * n - 2; j++)
            {
                Console.Write('/');
            }
            Console.Write(ast);
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        FirstLastRow(n);
        Middle(n);
        FirstLastRow(n);
    }
}
