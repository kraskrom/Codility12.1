/*
Two positive integers N and M are given. Integer N represents the number of chocolates arranged in a circle, numbered from 0 to N − 1.

You start to eat the chocolates. After eating a chocolate you leave only a wrapper.

You begin with eating chocolate number 0. Then you omit the next M − 1 chocolates or wrappers on the circle, and eat the following one.

More precisely, if you ate chocolate number X, then you will next eat the chocolate with number (X + M) modulo N (remainder of division).

You stop eating when you encounter an empty wrapper.

For example, given integers N = 10 and M = 4. You will eat the following chocolates: 0, 4, 8, 2, 6.

The goal is to count the number of chocolates that you will eat, following the above rules.

Write a function:

class Solution { public int solution(int N, int M); }

that, given two positive integers N and M, returns the number of chocolates that you will eat.

For example, given integers N = 10 and M = 4. the function should return 5, as explained above.

Write an efficient algorithm for the following assumptions:

N and M are integers within the range [1..1,000,000,000].
*/

using System;

namespace Codility12._1
{
    class Solution
    {
        public int gcd(int a, int b, int res)
        {
            if (a == b)
                return res * a;
            if (a % 2 == 0 && b % 2 == 0)
                return gcd(a / 2, b / 2, 2 * res);
            if (a % 2 == 0)
                return gcd(a / 2, b, res);
            if (b % 2 == 0)
                return gcd(a, b / 2, res);
            if (a > b)
                return gcd(a - b, b, res);
            return gcd(a, b - a, res);
        }

        public int solution(int N, int M)
        {
            return N / gcd(N, M, 1);
        }
    }

    class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            int N = 10;
            int M = 4;
            int s = sol.solution(N, M);
            Console.WriteLine("Solution: " + s);
            //Console.WriteLine("Solution: " + string.Join(", ", s));
        }
    }
}
