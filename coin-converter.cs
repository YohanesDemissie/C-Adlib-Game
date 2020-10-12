using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      
      Console.WriteLine("Please type how much cents do you have to convert: ");
      double amount = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"{amount} is equal to...");

    int gold = 10;
    int silver = 5;
    // int bronzeCoin = 1;
    //finding out how many gold coins we can use
    double goldCoins = Math.Floor(amount / gold);
    //how much is left over
    double remainder = amount % gold;

    //how much silver can we use
    double silverCoins = Math.Floor(remainder / silver);

    //how much is left over
     remainder = remainder % silver;

Console.WriteLine($"Gold Coins: {goldCoins} \n Silver Coins: {silverCoins} \n Bronze Coins: {remainder}");


    }
  }
}
