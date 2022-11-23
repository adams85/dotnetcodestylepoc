using System;
using System.Threading.Tasks;

namespace codestyle_poc;

class Program
{
    public static async Task Main(string[] args)
    {
        await Task.Delay(1000).ConfigureAwait(false);

        Console.WriteLine("Hello, World!");
    }
}
