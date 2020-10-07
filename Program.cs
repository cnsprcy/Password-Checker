using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
    // define and set all password standards
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "1234567890";
      string specialChars = "!@#$%^&*?_-=+";
    
    // capture users password
      Console.Write("\nEnter your password: ");
      string password = Console.ReadLine();
      int dotLength = password.Length;

    // set score to 0, increase score by 1 if true || by 0 if false and score users password
      int score = 0;
    // min length
      if (dotLength >= minLength)
      {
        score++;
      }
      else
      {
        Console.WriteLine("Password not long enough.");
      }
    // uppercase
      if (Tools.Contains(password, uppercase))
      {
        score++;
      }
      else
      {
        Console.WriteLine("Password needs at least 1 uppercase letter.");
      }
    // lowercase
      if (Tools.Contains(password, lowercase))
      {
        score++;
      }
      else
      {
        Console.WriteLine("Password needs at least 1 lowercase letter.");
      }
    // digits
      if (Tools.Contains(password, digits))
      {
        score++;
      }
      else
      {
        Console.WriteLine("Password needs at least 1 digit.");
      }
    // special characters
      if (Tools.Contains(password, specialChars))
      {
        score++;
      }
      else
      {
        Console.WriteLine("Password needs at least 1 special character.");
      }

    // let user know how strong the password (score) is
      switch (score)
      {
        case 5:
      Console.WriteLine("Password is extremely strong");
          break;

        case 4:
          Console.WriteLine("Password is strong");
          break;

        case 3:
          Console.WriteLine("Password is good");
          break;

        case 2:
          Console.WriteLine("Password is okay");
          break;

        case 1:
          Console.WriteLine("Password is weak");
          break;

        default:
          Console.WriteLine("Password is extremely weak");
          break;
      }

    // if score <= 5; try again
      while(true)
      {
        if (score < 5)
        {
          Console.WriteLine("\nYour password is too weak.\n\nPassword MUST include; 8 characters, 1 uppercase, 1 lowercase, 1 number, and 1 special character.\n\nPlease try another password: ");
          password = Console.ReadLine();
        }
        else
        {
          Console.WriteLine("Password is great!");
        }
      break;
      }
    



// TEST TEST TEST TEST
      Console.WriteLine(score);


      




    }
  }
}
