using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography;

namespace CodeRingNumber1 {
  internal class Program {
    private static void Main(string[] args) {

      var userInput = Console.ReadLine();

      var keyValue = new Dictionary<string, string> {
        { "a", "z" },
        { "b", "y" },
        { "c", "x" },
        { "d", "w" },
        { "e", "v" },
        { "f", "u" },
        { "g", "t" },
        { "h", "s" },
        { "i", "r" },
        { "j", "q" },
        { "k", "p" },
        { "l", "o" },
        { "m", "n" },
        { "n", "m" },
        { "o", "l" },
        { "p", "k" },
        { "q", "j" },
        { "r", "i" },
        { "s", "h" },
        { "t", "g" },
        { "u", "f" },
        { "v", "e" },
        { "w", "d" },
        { "x", "c" },
        { "y", "b" },
        { "z", "a" },
        { " ", " " }
      };

      foreach (char ch in userInput) {
        foreach (var item in keyValue) {
          if (item.Key.Contains(ch)) {
            Console.Write(item.Value);
          }
        }
      }

      Console.ReadKey();
    }
  }
}
