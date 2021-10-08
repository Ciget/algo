
using System;

namespace Starter
{
    public static class NumberOfProvinces
    {
        private static int find(int[] parent, int i)
        {
            if (parent[i] == -1)
            {
                return i;
            }

            return find(parent, parent[i]);
        }

        private static void union(int[] parent, int x, int y)
        {
            int xset = find(parent, x);
            int yset = find(parent, y);

            if (xset != yset)
            {
                parent[xset] = yset;
            }
        }

        public static int GetResult(int[,] input)
        {

            int[] parent = new int[input.GetLength(0)];
            Array.Fill(parent, -1);

            int count = 0;

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(0); j++)
                {
                    Console.WriteLine("i: " + i + "; j: " + j);
                    if (input[i,j] == 1 && i != j)
                    {
                    
                        union(parent, i, j);
                    }
                }
            }

            for (int i = 0; i < parent.Length; i++)
            {
                if (parent[i] == -1) count++;
            }
            return count;
        }
    }
}
