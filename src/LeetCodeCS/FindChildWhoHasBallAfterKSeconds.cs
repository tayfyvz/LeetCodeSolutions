public class Solution
{
    public int NumberOfChild(int n, int k)
    {
        int totalRound = k / (n - 1);

        int remaining = k % (n - 1);

        if(totalRound % 2 == 0)
        {
            return remaining;
        }
        else
        {
            return (n- 1) - remaining;
        }
    }
}