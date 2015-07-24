using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FirstTFour");

            var copyClass = new CopyClass();
            Console.WriteLine("copyClass.Name : " +  copyClass.Name);

            var foo = new Foo();
            Console.WriteLine("foo.Name : " + foo.Name);

            var bar = new Bar();
            Console.WriteLine("bar.Name : " + bar.Name);

            Console.ReadLine();
        }
    }
}
