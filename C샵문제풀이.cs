/*using System;
    class Number
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        Console.WriteLine(a[0]);
        Console.WriteLine(a[1]);
        Console.WriteLine(a[2]);
        Console.WriteLine(a[3]);
    }
}
*/

// p45 도전
/*
using System;
class Hello
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");
    }
}

using System;
class data
{
    public static void Main()
    {
        int a=2, b=3;

        Console.WriteLine(a=b);
    }
}

using System;
class sweets
{
    public static void Main()
    {
        int a = 128;
        int b = a + 200;
        string c = "C#";

        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}

using System;
class number
{
    public static void Main()
    {
        int[] a = new int[4];
        a[0] = 1;
        a[1] = 2;
        a[2] = 3;
        a[3] = 4;

        Console.WriteLine(a[2]);
    }
}
using System;
class number
{
    public static void Main()
    {
        int[] a = new int[] { 1, 2, 3, 4 };

        Console.WriteLine(a[2]);
    }
}
using System;
class enumsample
{
    enum Animal { mouse, cat, bird, dog = 100, koala, pig = 200, lion };
    public static void Main() {

        Console.WriteLine(Animal.bird);
        Console.WriteLine((int) Animal.koala);
        Console.WriteLine((int) Animal.lion);
        Console.WriteLine(Animal.lion);  
    }
}

using System;
class number
{
    public static void Main()
    {
        int a = 10;
        int b = 0, c = 0, d = 0,  e = 0;

        b = a++;
        c = ++a;
        d = a--;
        e = --a;

        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);

    }
}

using System;
class Foreach
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4 };

        foreach (int a in nums)
            Console.WriteLine(a);
    }
}
*/
using System;
class Program
{
    static void Main()
    {
        int[] myPos = { 20, 30 }; //자신이 있는 위치
        int[,] enemyPos = //적이 있는 위치
        {
            { 2,4 },
            { 10, 6 },
            { 25, 20 }

        };
        int i;
        int dx, dy;
        double d;
        double r = 15; //사정거리
        for (i=0;i<3;i++)
        {
            dx = myPos[0] - enemyPos[i, 0]; // 20 - 2
            dy = myPos[1] - enemyPos[i, 1]; // 30 - 4
            d = (double)(dx * dx + dy * dy); // x^2 + y^2 = (a~c)^2, 적과 나의 사이 거리
            if (d>r*r) // r*r = (a~c)^2, 사정거리
            {
                Console.WriteLine("적" + i + "은(는)" + "사정권 밖에 있음");

            }
            else
            {
                Console.WriteLine("적" + i + "은(는)" + "사정권 안에 있음");
            }
        }
    }
}