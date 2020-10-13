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

    switch(score) {
      case 8:
      Console.WriteLine("Your password is extremely strong.");
      break;
      case 7:
      Console.WriteLine("Your password is extremely strong.");
      break;
      case 6:
      Console.WriteLine("Your password is extremely strong.");
      break;
      case 5:
      Console.WriteLine("Your password is extremely strong.");
      break;
      case 4:
      Console.WriteLine("Your password is extremely strong.");
      break;
    case 3:
      Console.WriteLine("Your password is strong.");
      break;
    case 2:
      Console.WriteLine("Your passsword is medium.");
      break;
    case 1: 
      Console.WriteLine("Your passward is weak.");
      break;
    default:
      Console.WriteLine("The password doesn't meet any of the standards. Please try again.");
      break;
    }

    }
  }
}
