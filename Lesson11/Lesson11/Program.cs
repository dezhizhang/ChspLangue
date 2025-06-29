// See https://aka.ms/new-console-template for more information

namespace Lesson11
{
    enum MyEnum
    {
        Money,
        WoMoney
    }
    class Program
    {
        public static void Main(string[] args)
        {
           Console.WriteLine(MyEnum.Money);
           Console.WriteLine(MyEnum.WoMoney);
        }
    }
}