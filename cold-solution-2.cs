using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine(new string[2]{"",""}.Select(x => Console.ReadLine()).ToArray()[1].Count(x => x.Equals('-')));
  }
}
