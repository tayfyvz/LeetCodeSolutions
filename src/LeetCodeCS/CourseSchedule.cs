public class CourseSchedule
{
    public bool CanFinish(int numCourses, int[][] prerequisites) 
    {
        List<List<int>> adj = new List<List<int>>(numCourses);

        for (int i = 0; i < numCourses; i++)
        {
            adj.Add(new List<int>());
        }

        foreach (int[] pre in prerequisites)
        {
            adj[pre[0]].Add(pre[1]);
        }
        
        int[] visited = new int[numCourses];

        for (int i = 0; i < numCourses; i++)
        {
            if (visited[i] == 0 && !dfs(adj, visited, i))
            {
                return false;
            }
        }
        return true;
    }

    private bool dfs(List<List<int>> adj, int[] visited, int i)
    {
        if (visited[i] == 1)
        {
            return false;
        }
        if (visited[i] == 2)
        {
            return true;
        }

        visited[i] = 1;
        foreach (int neighbor in adj[i])
        {
            if (!dfs(adj, visited, neighbor))
            {
                return false;
            }
        }
        visited[i] = 2;
        return true;
    }
}