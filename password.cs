using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      Console.WriteLine("Please input password: ");
      string password = Console.ReadLine();
      int score = 0;

      if(password.Length >= minLength)
      {
        score += 1;
      };
      if(Tools.Contains(password, password.ToUpper()))
      {
        score +=1;
      }
      if(Tools.Contains(password, password.ToLower()))
      {
        score += 1;
      }
      if(Tools.Contains(password, "1234567890"))
      {
        score += 1;
      }
      if(Tools.Contains(password, "!@#$%^&*()-_"))
      {
        score += 1;
      }
      Console.WriteLine($"Youre password score is {score}/8.");
    }
  }
}
