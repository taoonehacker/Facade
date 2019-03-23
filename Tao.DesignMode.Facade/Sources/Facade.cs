using System;
namespace Tao.DesignMode.Facade.Sources
{
    public class Facade
    {
        SubSystemOne systemOne;
        SubSystemTwo systemTwo;
        SubSystemThree systemThree;
        SubSystemFour systemFour;

        public Facade()
        {
            systemOne = new SubSystemOne();
            systemTwo = new SubSystemTwo();
            systemThree = new SubSystemThree();
            systemFour = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\n 方法组A：");
            systemOne.MethodOne();
            systemTwo.MethodTwo();
            systemFour.MethodFour();

        }

        public void MethodB()
        {
            Console.WriteLine("\n 方法组B：");
            systemTwo.MethodTwo();
            systemThree.MethodThree();
        }
    }

}
