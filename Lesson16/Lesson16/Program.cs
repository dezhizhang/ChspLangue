// See https://aka.ms/new-console-template for more information

namespace Lesson16
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Stack<string> stack = new Stack<string>();
            stack.Push("Hello");
            stack.Push("World");
            
            
            string[] os = stack.ToArray();
            
            
            Console.WriteLine(os.Length);

            for (int i = 0; i < os.Length; i++)
            {
                Console.WriteLine(os[i]);
            }
            
            
            
        }
    }
}