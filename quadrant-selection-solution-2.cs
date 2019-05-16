using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine(new Dictionary<string, int>(){{"++", 1 },{"-+", 2 },{"--", 3},{"+-", 4}}[string.Join("", new string[2]{"",""}.Select(x => Console.ReadLine()[0] == '-' ? "-" : "+").ToArray())]);
  }
}
