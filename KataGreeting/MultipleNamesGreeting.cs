using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataGreeting
{
    internal class MultipleNamesGreeting : GreetHandler
    {
        public override string Greet(params string[] name)
        {
            string res = "Hello,";
            if (name.Any(n => n != n.ToUpper()) && !name.Any(n => n.Contains(',')) && !name.Any(n => n.StartsWith("\"") && n.EndsWith("\"")))
            {
                for (int i = 0; i < name.Length - 2; i++)
                {
                    res += $"{name[i]},";
                }
                res += $"and {name[name.Length - 1]}";
                return res ;
            } else
            {
                return Next.Greet(name);
            }
        }
    }
}
