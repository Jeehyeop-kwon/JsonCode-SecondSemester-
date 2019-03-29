using System;

namespace JsonSpring
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonHelper jsonHelper = new JsonHelper();
            jsonHelper.ReadJsonFile(@"/Users/jeehyeopkwon/Desktop/test.json");

            Student s = jsonHelper.JsonParser();
            Console.WriteLine(s.email);
            Console.WriteLine(s.firstName);
            Console.WriteLine(s.lastName);
        }
    }
}
