using System;

namespace ListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 4, 5, 8, 9, 12, 54, 55, 65 };

            var list = new MyList<int>(arr);

            int result = list.BinarySearch(3, 3, 1, null);

			Console.WriteLine(result);
        }

    }
}
