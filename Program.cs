﻿// 1

//int n = int.Parse(Console.ReadLine());

//int min = 0;
//int max = 0;

//for (int i = 0; i < n; i++)
//{
//    int toplam = int.Parse(Console.ReadLine());

//    if (i == 0)
//    {
//        min = toplam;
//        max = toplam;
//    }
//    if (toplam > max)
//    {
//        toplam = max;
//    }
//    if (toplam < min)
//    {
//        toplam = min;
//    }
//}
//Console.WriteLine("Max: " + max);
//Console.WriteLine("Min: " + min);


// 2

//Console.Write("Nechta to'rtburchak?: ");
//float n = float.Parse(Console.ReadLine());
//float minS = 1, min = 0;

//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine(i + " - to'rtburchak");
//    Console.Write("a: ");
//    int a = int.Parse(Console.ReadLine());
//    Console.Write("b: ");
//    int b = int.Parse(Console.ReadLine());

//    minS = a * b;
//    if (i == 1)
//    {
//        min = minS;
//    }

//    if (min < minS)
//    {
//        minS = min;
//    }
//}
//Console.WriteLine("Min: " + minS);


// 3

//int n = int.Parse(Console.ReadLine());

//float perimetri = 0, a, b;

//float maxPer = 0;

//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine(i + " - torburchak");
//    Console.Write("a: ");
//    a = float.Parse(Console.ReadLine());
//    Console.Write("b: ");
//    b = float.Parse(Console.ReadLine());

//    maxPer = (a + b) * 2;

//    if (i == 1)
//    {
//        maxPer = perimetri;
//    }

//    if (perimetri > maxPer)
//    {
//        maxPer = perimetri;
//    }
//}
//Console.WriteLine("Max Perimetri: " + maxPer);


// 4

//int n = int.Parse(Console.ReadLine());
//float r, min = 0, minnum = 0;


//for (int i = 0; i < n; i++)
//{
//    r = float.Parse(Console.ReadLine());

//    if ((i == 0) || (r < min))
//    {
//        min = r;
//        minnum = i;
//    }

//}
//Console.WriteLine(minnum);


// 5

//float m, v, p, pmax = 0;
//int n, maxnum = 0;
//Console.Write("N: ");
//n = int.Parse(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    m = float.Parse(Console.ReadLine());
//    v = float.Parse(Console.ReadLine());

//    p = m / v;

//    if ((i == 1) || (p > pmax))
//    {
//        pmax = p;
//        maxnum = i;
//    }
//}
//Console.WriteLine("i - n" + maxnum + " " + pmax);


// 6

//int n = int.Parse(Console.ReadLine());

//int min = 0;
//int max = 0;

//for (int i = 0; i < n; i++)
//{
//    int everyNum = int.Parse(Console.ReadLine());
//    if (i == 0)
//    {
//        min = everyNum;
//        max = everyNum;
//    }
//    if (max < everyNum)
//    {
//        max = everyNum;
//    }
//    if (min > everyNum)
//    {
//        min = everyNum;
//    }
//}
//Console.WriteLine("Min: " + min);
//Console.WriteLine("Max: " + max);



// 7

//int n = int.Parse(Console.ReadLine());

//int min = 0;
//int max = 0;

//for (int i = 0; i < n; i++)
//{
//    int everyNum = int.Parse(Console.ReadLine());
//    if (i == 0)
//    {
//        min = everyNum;
//        max = everyNum;
//    }
//    if (max < everyNum)
//    {
//        max = everyNum;
//    }
//    if (min > everyNum)
//    {
//        min = everyNum;
//    }
//}
//Console.WriteLine("Min: " + min);
//Console.WriteLine("Max: " + max);


// 8

//int n = int.Parse(Console.ReadLine());

//int min = 0;
//int min2 = 0;

//for (int i = 0; i < n; i++)
//{
//    int everyNum = int.Parse(Console.ReadLine());
//    if (i == 0)
//    {
//        min = everyNum;
//        min2 = everyNum;
//    }
//    if (min > everyNum)
//    {
//        min = everyNum;
//    }
//    if (min2 < min && min2 < everyNum)
//    {
//        min2 = everyNum;
//    }

//}
//Console.WriteLine("Min: " + min);
//Console.WriteLine("Min2: " + min2);


// 9

//int n = int.Parse(Console.ReadLine());

//int max = 0;
//int max2 = 0;

//for (int i = 0; i < n; i++)
//{
//    int everyNum = int.Parse(Console.ReadLine());
//    if (i == 0)
//    {
//        max = everyNum;
//        max2 = everyNum;
//    }
//    if (max > everyNum)
//    {
//        max = everyNum;
//    }
//    if (max2 < max && max2 < everyNum)
//    {
//        max2 = everyNum;
//    }

//}
//Console.WriteLine("Max: " + max);
//Console.WriteLine("Max2: " + max2);


// 10


//int n = int.Parse(Console.ReadLine());

//int minn = 0, maxn = 0, min = 0, max = 0;

//for (int i = 0; i < n; i++)
//{
//    int toplamSoni = int.Parse(Console.ReadLine());

//    if ((i == 1) || (toplamSoni < min))
//    {
//        min = toplamSoni;
//        minn = i;
//    }
//    if ((i == 1) || (toplamSoni > max))
//    {
//        max = toplamSoni;
//        maxn = i;
//    }
//}

//Console.WriteLine(minn < maxn ? minn : maxn);


// 11

//int n = int.Parse(Console.ReadLine());

//int minn = 0, maxn = 0, min = 0, max = 0;

//for (int i = 0; i < n; i++)
//{
//    int toplamSoni = int.Parse(Console.ReadLine());

//    if ((i == 1) || (toplamSoni <= min))
//    {
//        min = toplamSoni;
//        minn = i;
//    }
//    if ((i == 1) || (toplamSoni >= max))
//    {
//        max = toplamSoni;
//        maxn = i;
//    }
//}

//Console.WriteLine(minn < maxn ? minn : maxn);



// 12

//int n = int.Parse(Console.ReadLine());

//int min = 0;

//for (int i = 1; i <= n; i++)
//{
//    int toplam = int.Parse(Console.ReadLine());

//    if (((toplam < min) && (toplam > 0)) || (min < 0))
//    {
//        min = toplam;
//    }
//}
//Console.WriteLine(min > 0 ? 0 : min);


// 13

//int n = int.Parse(Console.ReadLine());

//int max = 0, maxnum = 0;

//for (int i = 1; i <= n; i++)
//{
//    int top = int.Parse(Console.ReadLine());

//    if ((top % 2 != 0 && top > max) || (i == 1))
//    {
//        max = top;
//        maxnum = i;
//    }
//}
//Console.WriteLine(maxnum);


// 14

//float b, r, min = 0;
//int minnum = 0, i;

//Console.Write("B: ");
//b = int.Parse(Console.ReadLine());

//for (i = 1; i <= 10; ++i)
//{
//    r = int.Parse(Console.ReadLine());

//    if ((r > b) && ((r < min) || (minnum == 0)))
//    {
//        min = r;
//        minnum = i;
//    }
//}
//Console.Write(minnum + " " + min);


// 15

//float b, c, r, max = -1;
//int maxnum = 0, i;

//Console.Write("B:");
//b = float.Parse(Console.ReadLine());
//Console.Write("C:");
//c = float.Parse(Console.ReadLine());

//for (i = 1; i <= 10; ++i)
//{
//    r = float.Parse(Console.ReadLine());

//    if ((b < r) && (r < c) && ((r > max) || (maxnum == 0)))
//    {
//        max = r;
//        maxnum = i;
//    }
//}
//Console.Write(maxnum + " " + max);


// 16

//int minnum = 0, i, n, r, min = 0;

//Console.Write("N:");
//n = int.Parse(Console.ReadLine());

//for (i = 1; i <= n; ++i)
//{
//    r = int.Parse(Console.ReadLine());

//    if ((r < min) || (i == 1))
//    {
//        min = r;
//        minnum = i;
//    }
//}
//Console.Write(minnum - 1);


// 17

Console.Write("N: ");
int n = int.Parse(Console.ReadLine()),
    ni, max = 0, maxnum = 0, resnum = 0;

for (int i = 1; i <= n; i++)
{
    ni = int.Parse(Console.ReadLine());

    if (ni > max || (i == 1))
    {
        max = ni;
        maxnum = i;
        resnum = 0;
    }
    else if (ni == max)
    {
        resnum = i - 1 - maxnum;
    }
}
Console.WriteLine(resnum);