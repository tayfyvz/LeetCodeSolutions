public class DistanceOfTheNearestZero
{
    public int[][] UpdateMatrix(int[][] mat)
    {
        Queue<(int row, int column, int distance)> queue = new Queue<(int row, int column, int distance)>();
        
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[0].Length; j++)
            {
                if (mat[i][j] == 0)
                {
                    queue.Enqueue((i, j, 0));
                }
                else
                {
                    mat[i][j] = Int32.MaxValue;
                }
            }
        }

        while (queue.Count > 0)
        {
            var (row, column, distance) = queue.Dequeue();

            if (mat[row][column] > distance)
            {
                mat[row][column] = distance;
            }
            
            if (row - 1 >= 0 && mat[row - 1][column] == Int32.MaxValue)
            {
                queue.Enqueue((row - 1, column, distance + 1));
            }
            if (row + 1 < mat.Length && mat[row + 1][column] == Int32.MaxValue)
            {
                queue.Enqueue((row + 1, column, distance + 1));
            }
            if (column - 1 >= 0 && mat[row][column - 1] == Int32.MaxValue)
            {
                queue.Enqueue((row, column - 1, distance + 1));
            }
            if (column + 1 < mat[0].Length && mat[row][column + 1] == Int32.MaxValue)
            {
                queue.Enqueue((row, column + 1, distance + 1));
            }
        }
        
        return mat;
    }
}