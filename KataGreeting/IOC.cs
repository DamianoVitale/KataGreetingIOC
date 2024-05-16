using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KataGreeting
{
    internal class IOC
    {

        public static IHost CreateHostBuilder()
        {
            return Host
                .CreateDefaultBuilder()
                .ConfigureServices((_, service) =>
                {
                  
                    service.AddSingleton<GreetHandler>((x) =>
                    {
                   
                        var simpleGreeting = new SimpleGreeting();
                        var nullGreeting = new NullGreeting();
                        var upperGreeting = new UpperGreeting();
                        var twoNameGreeting = new TwoNameGreeting();
                        var multipleNameGreeting = new MultipleNamesGreeting();
                        var mixed = new MixedGreeting();
                        var commaSeparatedGreeting = new CommaSeparatedGreeting();
                        var escapedGreeting = new EscapedGreeting();

                        simpleGreeting
                          .SetSuccesor(nullGreeting)
                          .SetSuccesor(upperGreeting)
                          .SetSuccesor(twoNameGreeting)
                          .SetSuccesor(multipleNameGreeting)
                          .SetSuccesor(mixed)
                          .SetSuccesor(commaSeparatedGreeting)
                          .SetSuccesor(escapedGreeting);

                        return simpleGreeting;

                    });
                }).Build();
        }

    }
}
