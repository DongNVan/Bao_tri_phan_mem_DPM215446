using Singleton;

class Program
{
    static void Main(string[] args)
    {
        singleton s1 = singleton.Instance();
        singleton s2 = singleton.Instance();

        if (s1 == s2)
        {
            Console.WriteLine("Objects are the same instance");
        }

        Console.ReadKey();
    }
}