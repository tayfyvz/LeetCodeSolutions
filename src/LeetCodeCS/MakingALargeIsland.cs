using System;
using System.Collections.Generic;

public class Solution
{
    public int LargestIsland(int[][] grid)
    {
        bool hasZero = false;

        int maxIsland = 0;
        int index = 2;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] dirX = [1, -1, 0, 0];
        int[] dirY = [0, 0, 1, -1];

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    int size = 0;

                    // Check for island
                    Stack<Tuple<int, int>> tuples = new Stack<Tuple<int, int>>();

                    tuples.Push(new Tuple<int, int>(i, j));
                    grid[i][j] = index;

                    while (tuples.Count > 0)
                    {
                        var pair = tuples.Pop();

                        size++;

                        for(int k = 0; k < 4; k++)
                        {
                            if(pair.Item1 + dirX[k] < grid.Length &&
                                pair.Item1 + dirX[k] >= 0 &&
                                pair.Item2 + dirY[k] < grid[0].Length &&
                                pair.Item2 + dirY[k] >= 0 &&
                                grid[pair.Item1 + dirX[k]][pair.Item2 + dirY[k]] == 1)
                            {
                                grid[pair.Item1 + dirX[k]][pair.Item2 + dirY[k]] = index;
                                tuples.Push(new Tuple<int, int>(pair.Item1 + dirX[k], pair.Item2 + dirY[k]));
                            }
                        }
                    }

                    dict[index] = size;
                    maxIsland = Math.Max(maxIsland, size);
                    index++;
                }
                else
                {
                    hasZero = true;
                }
            }
        }

        if (!hasZero)
        {
            return maxIsland;
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    HashSet<int> set = new HashSet<int>();
                    int newSize = 1;

                    for(int k = 0; k < 4; k++)
                    {
                        if(i + dirX[k] < grid.Length &&
                            i + dirX[k] >= 0 &&
                            j + dirY[k] < grid[0].Length &&
                            j + dirY[k] >= 0 &&
                            grid[i + dirX[k]][j + dirY[k]] > 1 &&
                            !set.Contains(grid[i + dirX[k]][j + dirY[k]]))
                        {
                            set.Add(grid[i + dirX[k]][j + dirY[k]]); 
                            newSize += dict[grid[i + dirX[k]][j + dirY[k]]];
                        }
                    }

                    maxIsland = Math.Max(maxIsland, newSize);
                }
            }
        }

        return maxIsland;

    }
}