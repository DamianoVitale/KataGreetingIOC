using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataGreeting
{
    internal class SimpleGreeting : GreetHandler
    {
        public override string Greet(params string[] name)
        {
           if (name.Length == 1 && name[0] is not null && name[0] != name[0].ToUpper())
            {
                return $"Hello, {name[0]}";  
            } else
            {
                return Next.Greet(name);
            }

        }

    }
}
