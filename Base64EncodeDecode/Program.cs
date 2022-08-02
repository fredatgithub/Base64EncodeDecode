using System;

namespace Base64EncodeDecode
{
  internal class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      Display("Encode and decode with Base 64");
      Display(string.Empty);

      string clearText = "A long long time ago in a galaxy far far away";
      string secret = CryptoUtilities.Base64Encode(clearText);
      Display("Clear text is:");
      Display(clearText);
      Display("Base 64 encoded is:");
      Display(secret);
      for (char i = 'a'; i < 'o'; i++)
      {
        Display($"Clear text is: {i} and encoded is: {CryptoUtilities.Base64Encode(i.ToString())}");
        //Display(i.ToString());
        //Display("Base 64 encoded is:");
        //Display(CryptoUtilities.Base64Encode(i.ToString()));
      }

      Display("Press any key to exit:");
      Console.ReadKey();

    }
  }
}
