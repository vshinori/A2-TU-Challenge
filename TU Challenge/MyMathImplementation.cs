using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static bool IsMajeur(int age)
        {
            return age >= 18;
        }

        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        public static bool IsDivisible(int a, int b)
        {
            return a % b == 0;
        }

        public static bool IsPrimary(int a)
        {
            if (a == 0 || a == 1)
                return false;
            int i = 1;
            while (a % i != 0)
            {
                i++;
                if (i == a)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public static List<int> GetAllPrimary(int a)
        {
            int i = 2;
            int count = 0;
            List<int> result = new();
            while (count < a)
            {
                if (IsPrimary(i))
                    result.Add(i);
                i++;
            }
            return result;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static int Power(int a, int b)
        {
            int result = 1;
            while (b > 0)
            {
                result *= a;
                b--;
            }
            return result;
        }

        public static int IsInOrder(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a > b)
                return -1;
            return 0;
        }

        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                    return false;
            }
            return true;
        }

        public static List<int> Sort(List<int> list)
        {
            for (int i = 1; i < list.Count - 1; i++)
            {
                int nb = list[i];
                int j = i;
                while (list[j - 1] > nb || j >= 0)
                {
                    list[j] = list[j - 1];
                    j--;

                }
                list[j] = nb;
            }
            return list;
        }
    }
}
