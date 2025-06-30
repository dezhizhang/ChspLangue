// See https://aka.ms/new-console-template for more information

using System.Collections;

namespace Lesson14
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("A");
            list.Add("B");

            list.Add("F");
            list.Add("C");
            list.Add("D");
            list.Add("E");

            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}