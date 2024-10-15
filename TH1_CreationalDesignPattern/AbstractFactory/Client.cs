using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Client
    {
        public void ClientMethod(ThoiTrang factory)
        {
            Ao ao = factory.createAo();
            Giay giay = factory.createGiay();
            Console.WriteLine(ao.getName());
            Console.WriteLine(ao.getModel());
            Console.WriteLine(giay.getName());
            Console.WriteLine(giay.getModel());
            Console.WriteLine("******************************");
        }
    }
}
