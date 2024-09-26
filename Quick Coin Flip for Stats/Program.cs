// See https://aka.ms/new-console-template for more information
Console.WriteLine("20 Million Coinflips");
int h = 0;
int t = 0;
for (int i = 0; i < 20000000; i++) // h/t ~~ 1 as lim i->inf *might integrate async if trying larger than 20m
{
    bool state = Coins.CoinFlip();
    if (state==true)
    {
        h++;
    }
    else
    {
        t++;
    }
}
Console.WriteLine("Heads: "+ h);
Console.WriteLine("Tails: "+ t);
public static class Coins
{
    public static bool CoinFlip()
    {
        Random rand = new Random();
        int n = Convert.ToInt16(rand.Next(1,3));
        if (is_even(n))
        {
            return true;
        }
        else { return false; }
    }
    public static bool is_even(int n)
    {
        return n % 2 != 0;
    }
}