using AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Abstract factory demo:");
        Console.WriteLine("**********");

        Client client = new Client();

        client.ClientMethod(new ThoiTrangMuaHe());

        client.ClientMethod(new ThoiTrangMuaDong());

        Console.ReadKey();
    }
}