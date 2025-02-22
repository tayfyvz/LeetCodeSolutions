public class InsertInterval
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> result = new List<int[]>();
        bool isImported = false;

        if (intervals == null || intervals.Length == 0)
        {
            result.Add(newInterval);
            return result.ToArray();
        }
        
        for (int i = 0; i < intervals.Length; i++)
        {
            if (intervals[i][1] < newInterval[0])
            {
                result.Add(intervals[i]);
            }
            else if (intervals[i][0] <= newInterval[1])
            {
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            }
            else
            {
                if (!isImported)
                {
                    result.Add(newInterval);
                    isImported = true;
                }
                
                result.Add(intervals[i]);
                
            }
        }
        if (!isImported)
        {
            result.Add(newInterval);
            isImported = true;
        }
        return result.ToArray();
    }    
}