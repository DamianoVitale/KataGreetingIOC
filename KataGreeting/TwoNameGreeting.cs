using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataGreeting
{
    internal class TwoNameGreeting : GreetHandler
    {
        public override string Greet(params string[] name)
        {
            if (name.Length == 2)
            {
                return $"Hello, {name[0]} and {name[1]}";
            }
            else
            {
                return Next.Greet(name);
            }
        }
    }
}
