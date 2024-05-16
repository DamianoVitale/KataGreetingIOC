using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataGreeting
{
    internal class MixedGreeting : GreetHandler
    {
        public override string Greet(params string[] name)
        {
            string res = "Hello,";
            List<string> lower = new List<string>(), upper = new List<string>();
            if (!name.Any(n => n.Contains(',')) && !name.Any(n => n.StartsWith("\"") && n.EndsWith("\"")))
            {
                for (int i = 0; i < name.Length - 1; i++)
                {
                    if (name[i] == name[i].ToUpper())
                    {
                        upper.Add(name[i]);
                    }
                    else
                    {
                        lower.Add(name[i]);
                    }
                }

                for (int i = 0; i < lower.Count - 2; i++)
                {
                    res += $"{lower[i]},";
                }
                res += $"and {lower[lower.Count - 1]}.";
                res += "HELLO ";

                for (int i = 0; i < upper.Count - 2; i++)
                {
                    res += $"{upper[i]},";
                }
                res += $"AND {upper[upper.Count - 1]}!";
                return res;
            }
            else
            {
                return Next.Greet(name);
            }
        }
    }
}
