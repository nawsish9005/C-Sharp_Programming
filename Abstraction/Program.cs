using System;
abstract class Payment
{
    public abstract void processPayment(double amount); // Abstract method
    public void PrintReceipt(double amount) // Concrete method
    {
        Console.WriteLine($"Payment of ${amount} processed successfully.");
    }
}

class PaypalPayment: Payment
{
    public override void processPayment(double amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount}...");
        PrintReceipt(amount);
    }
}

class CreditCardPayment: Payment
{
    public override void processPayment(double amount)
    {
        Console.WriteLine($"Processing Credit Card payment of ${amount}...");
        PrintReceipt(amount);
    }
}

class program
{
    static void Main()
{
    Payment mypayment=new PaypalPayment();
    mypayment.processPayment(100);

    Payment anotherp=new CreditCardPayment();
    anotherp.processPayment(200);
}
}
