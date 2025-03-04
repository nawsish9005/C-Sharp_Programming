using System;

public delegate void MyDelegate(string message);
class Program
{
    public static void ShowMessage(string msg)
    {
        Console.WriteLine("Message: " + msg);
    }
    static void Main()
    {
        MyDelegate del = new MyDelegate(ShowMessage);
        del("Hello, Delegates!");
    }
}
