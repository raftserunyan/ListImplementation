using System;
using System.Text;

namespace ListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder("Ereq");
            var arr = new[]
            {
                new StringBuilder("Mek"),
                new StringBuilder("Erku"),
                sb,
                null,
                new StringBuilder("Hing")
            };

            var list = new MyList<StringBuilder>(arr);

            int result = list.BinarySearch(0, arr.Length, sb, null);

			Console.WriteLine(result);
        }

    }
}
