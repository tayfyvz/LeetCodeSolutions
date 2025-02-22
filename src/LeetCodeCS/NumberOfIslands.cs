public class NumberOfIslands
{
    public int NumIslands(char[][] grid)
    {
        int islandsCount = 0;

        bool[][] visited = new bool[grid.Length][];
        for (int i = 0; i < grid.Length; i++)
        {
            visited[i] = new bool[grid[0].Length];
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1' && !visited[i][j])
                {
                    islandsCount++;
                    DFS(grid, i, j, visited);
                }
            }
        }
        
        return islandsCount;
    }

    private void DFS(char[][] grid, int i, int j, bool[][] visited)
    {
        Stack<(int x, int y)> stack = new Stack<(int x, int y)>();
        
        stack.Push((i, j));
        visited[i][j] = true;

        while (stack.Count > 0)
        {
            var (x, y) = stack.Pop();

            if (x - 1 >= 0 && grid[x - 1][y] == '1' && !visited[x - 1][y])
            {
                stack.Push((x - 1, y));
                visited[x-1][y] = true;
            }

            if (x + 1 < grid.Length && grid[x + 1][y] == '1' && !visited[x + 1][y])
            {
                stack.Push((x + 1, y));
                visited[x + 1][y] = true;
            }

            if (y - 1 >= 0 && grid[x][y-1] == '1' && !visited[x][y-1])
            {
                stack.Push((x, y - 1));
                visited[x][y-1] = true;
            }

            if (y + 1 < grid[0].Length && grid[x][y+1] == '1' && !visited[x][y+1])
            {
                stack.Push((x, y + 1));
                visited[x][y+1] = true;
            }
        }
    }
}