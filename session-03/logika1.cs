using System;

public class Logika1
{
    public static void Main() 
    {
        int a = 92;
        int b = 53;
        if(a > b) 
        {
            Console.WriteLine("a lebih besar dari b");
        }
        else if (a < b) 
        {
            Console.WriteLine("a lebih kecil dari b");
        }
        else if (a == b) {
            Console.WriteLine("a sama dengan b");
        }
    }
}