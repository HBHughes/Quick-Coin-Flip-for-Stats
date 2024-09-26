// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int h = 0;
int t = 0;
for (int i = 0; i < 30; i++) //30 coinflips
{
    bool state = Coins.CoinFlip();
    Console.WriteLine(state);
    if (state==true)
    {
        h++;
    }
    else
    {
        t++;
    }
}
Console.WriteLine(h);
Console.WriteLine(t);
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