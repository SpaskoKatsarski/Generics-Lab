using System;

namespace BoxOfT
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            box.Add(2);
            box.Add(0);
            box.Add(3);
            box.Add(1);

            Console.WriteLine(box.Count);
            Console.WriteLine(box.Remove());
            Console.WriteLine(box.Count);

            Box<bool> box2 = new Box<bool>();
            box2.Add(2 > 1);
        }
    }
}
