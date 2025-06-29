// See https://aka.ms/new-console-template for more information

namespace Lesson10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // // Console.WriteLine("123\b45678");
            // Console.WriteLine("Hello\nWorld!");

            // string s = "123";
            // Console.WriteLine(Convert.ToInt32(s));

            // string s = "23.3";
            // float i = Convert.ToSingle(s);
            // Console.WriteLine(i);

            // string s = "23.3";
            // double d = double.Parse(s);
            // Console.WriteLine($"{d:F2}");

            // string str = "123abc";
            // double num2; 
            // double.TryParse(str, out num2);
            // Console.WriteLine(num2);


           //  string str = "123abc";
           //  double num2;
           // bool b =  double.TryParse(str,out num2);
           // Console.WriteLine(b);
           // Console.WriteLine(num2);

           string str = "123";
           double num;
           bool b = double.TryParse(str, out num);
           if (!b)
           {
               Console.WriteLine("输入有误重新输入");
               return;
           }
           Console.WriteLine($"输入正确:{str}");

        }
    }
}