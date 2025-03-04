public delegate void MyDelegate(string message);
class Program
{
    public static void ShowMessage(string msg) => Console.WriteLine("Message: " + msg);
    public static void AnotherMethod(string msg) => Console.WriteLine("Another: " + msg);
    static void Main()
    {
        MyDelegate del = ShowMessage;
        del += AnotherMethod;
        del("Hello!");
    }
}
