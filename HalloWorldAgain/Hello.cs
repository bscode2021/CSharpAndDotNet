using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWorldAgain
{
    internal class Hello
    {
        public string name { get; set; }

        public Hello(string _name)
        {
            name = _name;
        }

        public void sayHallo()
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
