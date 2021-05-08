using System;

namespace PasswordCheck
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create password
      string password = "a92301j2add";

      // Get password length
      int passwordLength = password.Length;

      // Check if password uses symbol
      int passwordCheck = password.IndexOf("!");

      // Print results
      Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");

    }
  }
}

// $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$


using System;

namespace PasswordCheck
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Here");
      string userTweet = Console.ReadLine();
      
      int tweetLength = userTweet.Length;
      Console.WriteLine(tweetLength);

    }
  }
}
