using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataGreeting
{
    internal class EscapedGreeting : GreetHandler
    {
        public override string Greet(params string[] name)
        {
            string res = "Hello ";
            for (int i = 0; i < name.Length - 2; i++)
            {
                if (name[i].Contains("\""))
                {
                    name[i].Replace("\"", "");
                }
                res += $"{name[i]},";
            }
            res += $"and {name[name.Length - 1]}";
            return res;
        }
    }
}
