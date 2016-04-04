using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var foo = new Foo().Select("lolo").Where("lala").Execute();

            Console.WriteLine(foo);
        }
    }
}
