using System;
using System.Collections;
using System.Collections.Generic;

public class Solution
{
    public int MaxAreaOfIsland(int[][] grid)
    {
        int maxArea = 0;

        bool[][] visited = new bool[grid.Length][];

        for (int i = 0; i < grid.Length; i++)
        {
            visited[i] = new bool[grid[0].Length];
        }

        int[] dirX = [1, -1, 0, 0];
        int[] dirY = [0, 0, 1, -1];

        for (int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1 && !visited[i][j])
                {
                    visited[i][j] = true;

                    int count = 0;
                    Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
                    queue.Enqueue(new Tuple<int, int>(i, j));

                    while (queue.Count > 0)
                    {
                        var piece = queue.Dequeue();
                        int x = piece.Item1;
                        int y = piece.Item2;

                        count++;

                        for(int k = 0; k < 4; k++)
                        {
                            int newX = x + dirX[k];
                            int newY = y + dirY[k];

                            if(newX >= 0 && newX < grid.Length
                                && newY >= 0 && newY < grid[0].Length
                                && grid[newX][newY] == 1
                                && !visited[newX][newY])
                            {
                                visited[newX][newY] = true;
                                queue.Enqueue(new Tuple<int, int>(newX, newY));
                            }
                        }
                    }

                    maxArea = Math.Max(maxArea, count);
                }
            }
        }

        return maxArea;
    }
}