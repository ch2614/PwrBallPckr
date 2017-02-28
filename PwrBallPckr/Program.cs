using System;
using System.Collections.Generic;
using System.Linq;

namespace PwrBallPckr
{
    class Program
  {
     static void Main(string[] args)
    {
      //69 total white balls
      //26 total red (power) balls

      string pbLine;
      List<string> pbPicks;

      pbPicks = new List<string>();

      for (int i = 1; i <= 50000000; i= i+1 )
        {
          var numlist = Enumerable.Range(1, 69).ToList();
        
          var rnd = new Random(i); 

          var tmp = rnd.Next(0, numlist.Count() - 1);
          var num1 = numlist[tmp];
          numlist.Remove(num1);

          tmp = rnd.Next(0, numlist.Count() - 1);
          var num2 = numlist[tmp];
          numlist.Remove(num2);

          tmp = rnd.Next(0, numlist.Count() - 1);
          var num3 = numlist[tmp];
          numlist.Remove(num3);

          tmp = rnd.Next(0, numlist.Count() - 1);
          var num4 = numlist[tmp];
          numlist.Remove(num4);

          tmp = rnd.Next(0, numlist.Count() - 1);
          var num5 = numlist[tmp];
          numlist.Remove(num5);

          var pb = rnd.Next(1, 26);

          var comp_sum = num1 + num2 + num3 + num4 + num5 + pb;

          if (comp_sum >= 149 && comp_sum <= 189) //this is the minimum sum and maximum sum of drawings from 2016 & 2017
          {
            pbLine = num1 + "-" + num2 + "-" + num3 + "-" + num4 + "-" + num5 + "---" + pb;
            pbPicks.Add(pbLine);
          }
          //Console.WriteLine("Numbers:  {0}, {1}, {2}, {3}, {4} -- {5}", num1, num2, num3, num4, num5, pb);
       }

      var rnd2 = new Random();
      var finalPick = rnd2.Next(0, pbPicks.Count-1);

      Console.WriteLine("Final Picked Numbers:  {0}", pbPicks[finalPick]);
      Console.WriteLine("Hit any key to exit............");
      Console.ReadKey();
    }
  }
}
