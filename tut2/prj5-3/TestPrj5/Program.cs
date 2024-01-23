// See https://aka.ms/new-console-template for more information
int[] TwoCoins(int[] coins, int target)
{
  for(int curr = 0; curr < coins.Length; curr++)
  {
    for(int next = curr + 1; next < coins.Length; curr++)
    {
      if(coins[curr] + coins[next] == target)
      {
        return new int[]{curr, next};
      }
    }
  }
  return new int[0];
}

int target = 60;
int[] coins = new int[] {5, 5, 50, 25, 10, 5};
int[] result = TwoCoins(coins, target);

// Multiple pairs