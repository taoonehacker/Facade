using System;

namespace Tao.DesignMode.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new Tao.DesignMode.Facade.Sources.Facade();
            facade.MethodA();
            facade.MethodB();

            Console.Read();

        }
    }
}
