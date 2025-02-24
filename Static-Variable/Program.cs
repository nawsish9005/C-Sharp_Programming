using System;
using System.Collections.Generic;

public class User
{
    private static int totalUsers = 0; // Static variable to track the total number of users
    public int UserId { get; private set; }
    public string Name { get; private set; }

    public User(string name)
    {
        totalUsers++; // Increment the counter when a new user is created
        this.UserId = totalUsers; // Assign a unique ID based on totalUsers
        this.Name = name;
    }

    // Static method to get the total number of users
    public static int GetTotalUsers()
    {
        return totalUsers;
    }

    public void DisplayUser()
    {
        Console.WriteLine($"User ID: {UserId}, Name: {Name}");
    }
}

class Program
{
    static void Main()
    {
        List<User> users = new List<User>();

        users.Add(new User("Alice"));
        users.Add(new User("Bob"));
        users.Add(new User("Charlie"));

        Console.WriteLine("\nList of Users:");
        foreach (var user in users)
        {
            user.DisplayUser();
        }

        Console.WriteLine($"\nTotal Users Registered: {User.GetTotalUsers()}");
    }
}
