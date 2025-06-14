using System;
using System.Collections.Generic;

public class Solution
{
    List<List<char>> res;

    public List<List<char>> FindPossibleWays(int n)
    {
        int[][] arr = new int[n][];
        
        res = new List<List<char>>();

        for (int i = 0; i < n; i++)
        {
            arr[i] = new int[n];
        }

        List<char> comb = new List<char>();

        DFS(arr, comb, 0, 0);

        return res;
    }

    private void DFS(int[][] arr, List<char> comb, int i, int j)
    {
        if(i >= arr.Length ||
                i < 0 ||
                j >= arr[0].Length ||
                j < 0)
        {
            return;
        }

        if (i == arr.Length -1 && j == arr.Length -1)
        {
            res.Add(new List<char>(comb));
        }

        comb.Add('D');
        DFS(arr, comb, i + 1, j);
        comb.RemoveAt(comb.Count - 1);

        
        comb.Add('R');
        DFS(arr, comb, i, j + 1);
        comb.RemoveAt(comb.Count - 1);
    }
}