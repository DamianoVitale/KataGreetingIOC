using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataGreeting
{
    internal class CommaSeparatedGreeting : GreetHandler
    {
        public override string Greet(params string[] name)
        {
            if (!name.Any(n => n.StartsWith("\"") && n.EndsWith("\"")))
            {
                string res = "Hello ";
                List<string> normal = new List<string>();
                List<string> comma = new List<string>();
                List<string> splitted = new List<string>();
                foreach (string s in name)
                {
                    if (s.Contains(','))
                    {
                        comma.Add(s);
                    }
                    else
                    {
                        normal.Add(s);
                    }
                }
                foreach (string s in comma)
                {
                    splitted.AddRange(s.Split(','));
                }
                normal.Concat(splitted);

                for (int i = 0; i < normal.Count - 2; i++)
                {
                    res += $"{normal[i]},";
                }
                res += $"and {normal[normal.Count - 1]}";
                return res;
            }
            else
            {
                return Next.Greet(name);
            }
        } 
    }
}
