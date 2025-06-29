// See https://aka.ms/new-console-template for more information
namespace Lesson12
{
    class Program
    {
        struct Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        public static void Main(string[] args)
        {
            Person people = new Person("tom",123);
            Console.WriteLine(people.name);
            Console.WriteLine(people.age);
            
        }

    }
}