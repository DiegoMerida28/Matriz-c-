using System;

class Program
{
    const int maxf = 3;
    const int maxc = 5;

    static void Main(string[ares])
    {
        float[,] a = new float[maxf, maxc];
        int f, c;

        //Leer el array
        for (f = 0, f < maxf; f++)
        {
            for (c = 0; c < maxc; c++)
            {
                a[a, c] = float.Parse(Console.ReadLine());
            }
        }

        //Escribir el array
        for (f = 0, f < maxf; f++)
        {
            for (c = 0; c < maxc; c++)
            {
                Console.Write(a[f, c] + "");
            }
            Console.WriteLine();
        }
    }
}