// See https://aka.ms/new-console-template for more information

namespace Lesson09
{
    class Program
    {
        public static void Main(string[] args)
        {
            // int age = 20;
            // string name = "John";
            // Console.WriteLine($"姓名:{name} 年龄:{age}");
            
            Console.WriteLine("请问您最喜欢的运动是什么!");
            string sport = Console.ReadLine();
            Console.WriteLine("好巧，我也喜欢{0}运动",sport);
            
        }

    }
}