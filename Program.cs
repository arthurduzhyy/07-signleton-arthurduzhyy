﻿public sealed class Singleton
{
    private Singleton() { }

    private static Singleton _instance;

    public static Singleton GetInstance()
    {
        if (_instance == null)
            _instance = new Singleton();
        return _instance;
    }

    public void SomeBusinessLogic() { }
}

public class Program
{
    public static void Main(string[] args)
    {
        var s1 = Singleton.GetInstance();
        var s2 = Singleton.GetInstance();

        if (s1 == s2)
            Console.WriteLine("Singleton works, both variables contain the same instance.");
        else
            Console.WriteLine("Singleton failed, variables contain different instances.");
    }
}