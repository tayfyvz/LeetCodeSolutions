using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public List<int> FindBuildingsRightSide(List<int> heights)
    {
        Stack<int> buildings = new Stack<int>();

        for (int i = heights.Count - 1; i >= 0; i--)
        {
            if(buildings.Count <= 0)
            {
                buildings.Push(heights[i]);
                continue;
            }

            int prevBuild = buildings.Peek();
            int height = heights[i];
            if (height > prevBuild)
            {
                buildings.Push(height);
            }
        }

        return buildings.ToList();
    }

    public List<int> FindBuildingsIsland(List<int> heights)
    {
        int left = 0;
        int right = heights.Count - 1;

        int leftMostHeight = 0;
        int rightMostHeight = 0;

        List<int> leftList = new List<int>();
        List<int> rightList = new List<int>();

        while (left < right)
        {
            int leftHeight = heights[left];

            if(leftHeight > leftMostHeight)
            {
                leftList.Add(left);
                leftMostHeight = leftHeight;
            }

            int rightHeight = heights[right];

            if(rightHeight > rightMostHeight)
            {
                rightList.Add(right);
                rightMostHeight = rightHeight;
            }

            if (leftMostHeight < rightMostHeight)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return leftList.AddRange(rightList);

    }
}