﻿using Builder;
class Program
{
    static void Main(string[] args)
    {
        Director director = new Director();
        builder b1 = new ConcreteBuilder1();
        builder b2 = new ConcreteBuilder2();
        
        director.Construct(b1);
        Product p1 = b1.GetResult();
        p1.Show();
        director.Construct(b2);
        Product p2 = b2.GetResult();
        p2.Show();
        
        Console.ReadKey();
    }
}