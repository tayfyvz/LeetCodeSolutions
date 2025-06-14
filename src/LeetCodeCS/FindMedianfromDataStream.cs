using System.Collections.Generic;

public class MedianFinder
{
    List<int> list;

    public MedianFinder()
    {
        list = new List<int>();
    }

    public void AddNum(int num)
    {
        if(list.Count == 0)
        {
            list.Add(num);
            return;
        }

        int start = 0;
        int end = list.Count - 1;
        int mid;
        while(start <= end)
        {
            mid = (start + end) / 2;

            if (list[mid] == num)
            {
                list.Insert(mid, num);
                return;
            }

            else if (list[mid] > num)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        list.Insert(start, num);
    }
    }

    public double FindMedian()
    {
        int size = list.Count;

        if(size == 0)
        {
            return 0.0;
        }

        if(size % 2 == 1)
        {
            return (double)list[size / 2];
        }
        else
        {
            return (double)(list[size / 2 - 1] + list[(size / 2)]) / 2.0;
        }
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */