// See https://aka.ms/new-console-template for more information

using System.Collections;

namespace Lesson15
{
    class Program
    {
        // public static void Main(string[] args)
        // {
        //     Hashtable ht = new Hashtable();
        //     ht.Add("name","小明");
        //     ht.Add("age","18");
        //     
        //     
        //     Console.WriteLine(ht["name"]);
        // }

        // public static void Main(string[] args)
        // {
        //     Hashtable ht = new Hashtable();
        //     ht.Add("name","小明");
        //     ht.Add("age","18");
        //     
        //     
        //     Console.WriteLine(ht["age"]);
        //     ht.Remove("name");
        //     Console.WriteLine(ht.ContainsKey("name"));
        //     
        // }

        // public static void Main(string[] args)
        // {
        //     Hashtable ht = new Hashtable();
        //     ht.Add("name","小明");
        //     ht.Add("age",22);
        //
        //     foreach (string key in ht.Keys)
        //     {
        //         Console.WriteLine(key);
        //     }
        // }

        // public static void Main(string[] args)
        // {
        //     Hashtable ht = new Hashtable();
        //     ht.Add("name","小明");
        //     ht.Add("age","18");
        //
        //     foreach (string key in ht.Values)
        //     {
        //         Console.WriteLine(key);
        //     }
        // }

        // public static void Main(string[] args)
        // {
        //     Hashtable ht = new Hashtable();
        //     ht.Add("name","小明");
        //     ht.Add("age","18");
        //
        //     foreach (string key in ht.Keys)
        //     {
        //         Console.WriteLine(key);
        //     }
        // }

        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("name","小明");
            ht.Add("age",18);


            foreach (string key in ht.Keys)
            {
                Console.WriteLine(key);
            }
        }


    }
}