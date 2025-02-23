public class CoinChange
{
    public int Solution(int[] coins, int amount) 
    {
        int[] dp = new int[amount + 1];

        for (int i = 1; i < amount+1; i++)
        {
            dp[i] = amount + 1;
        }
        
        dp[0] = 0;

        for (int i = 0; i < amount+1; i++)
        {
            for (int j = 0; j < coins.Length; j++)
            {
                if (i - coins[j] >= 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                }
            }
        }

        if (dp[amount] < amount + 1)
        {
            return dp[amount];
        }

        return -1;
    }    
}