using System;
using System.Linq;
using System.Threading.Tasks;
using Custom.Collections;

namespace codestyle_poc;

class Program
{
    public static async Task Main(string[] args)
    {
        await Task.Delay(500).ConfigureAwait(false);

        var dic = new OrderedDictionary<string, int>
        {
            ["a"] = 1,
            ["b"] = 2,
            ["c"] = 3,
        };

        Console.WriteLine(string.Join(", ", dic.Select(kvp => $"{kvp.Key}={kvp.Value}")));
    }
}
