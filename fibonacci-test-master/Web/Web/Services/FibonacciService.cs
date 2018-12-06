using System.Collections.Generic;

namespace Web.Services
{
    public class FibonacciService : IFibonacciService
    {
        public IEnumerable<int> GenerateFibonacciSequence(int numbersToGenerate)
        {
            // TODO: Have not done the implementation yet.
            List<int> list = new List<int>();
            for (int i = 0; i < numbersToGenerate; i++)
                list.Add(FibonacciSeries(i));
            return list;
        }

        public int FibonacciSeries(int n)
        {
            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
    }
}