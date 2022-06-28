using System;

namespace Destroy_Object
{
    class C1
    {
        public C1()
        {
            Console.WriteLine("Constructor :");
        }
        static C1()
        {
            Console.WriteLine("static constructor :");
        }
        public void show()
        {
            Console.WriteLine("Method :");
        }
        public string name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C1 obj = new C1();
            obj.show();
         
            obj.name = "akshay";
            Console.WriteLine(obj.name);
            obj = null;
            
        }
    }
}
