// See https://aka.ms/new-console-template for more information
using System;


class Box
{
    private int a,b,c;
    public Box(int p, int q, int r)
    {
        a = p;
        b = q;
        c = r;
    }
    public int Length()
    {
        return a;
    }
    public int Height()
    {
        return b;
    }
    public int Width()
    {
        return c;
    }
    public static Box operator +(Box faim, Box faim1)
    {
        return new Box(faim.Length() + faim1.Length(), faim.Height() + faim1.Height(), faim.Width() + faim1.Width());
    }
}


public class Class1
{
    static void Main()
    {

        /*A faim = new A();
        faim.set(5, 6);
        Console.WriteLine(faim.get());*/
        Box faim = new Box(2,2,3);
        Box faim1= new Box(3, 3, 3);
        Box faim2 = faim + faim1;
        Console.WriteLine( faim2.Width());
        Console.WriteLine( faim2.Height());
        Console.WriteLine( faim2.Length());
        Console.WriteLine(Math.Abs(-555));
        string s = "ABC";
        Console.WriteLine(s.Contains("BC"));
        string userInput= Console.ReadLine();
        int res = Convert.ToInt32(userInput);
        Console.WriteLine(res);
        int charInt = Console.Read();
        Console.WriteLine(charInt);


    }

}

/*class A
{
    private int a, b;
    public void set(int p, int q)
    {
        a = p; b = q; 
    }
    public bool get ()
    {
       return a>b?true:false;
    }

}
*/
