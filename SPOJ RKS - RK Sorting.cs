using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program;

class Program
{
    public static void Solve(int N, int C, List<int> list)
    {
        Dictionary<int, int> E = new Dictionary<int, int>();
        int currentCount;
        foreach (int i in list)

        {
            if (E.ContainsKey(i))
            {
                E.TryGetValue(i, out currentCount);
                E[i] = currentCount + 1;
            }

            else
            {
                E.Add(i, 1);
            }
        }

        E = E.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        for (int j = 0; j < E.Count; j++)
        {
            for (int k = 0; k < E.ElementAt(j).Value; k++)
            {
                Console.Write($"{E.ElementAt(j).Key} ");
            }
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        var firstLineInput = (Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), int.Parse));
        int N = firstLineInput[0];
        int C = firstLineInput[1];
        List<int> list = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(convertTemp => Convert.ToInt32(convertTemp)).ToList();
        Solve(N, C, list);
    }
}