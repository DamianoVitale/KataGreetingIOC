using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataGreeting
{
    public abstract class GreetHandler 
    {
        protected GreetHandler? Next;

        public GreetHandler SetSuccesor(GreetHandler next)
        {
            Next = next;
            return Next;
        }

        public abstract string Greet(params string[] name);
    }
}
