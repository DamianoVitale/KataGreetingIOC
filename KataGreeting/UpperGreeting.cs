using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataGreeting
{
    internal class UpperGreeting : GreetHandler
    {
        public override string Greet(params string[] name)
        {
            if (name.Length == 1)
            {
                return $"HELLO, {name[0]} ";
            }
            else
            {
                return Next.Greet(name);
            }
        }
    }
}
