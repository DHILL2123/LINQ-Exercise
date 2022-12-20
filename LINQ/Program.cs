using System;
using LINQ;
using System.Collections.Generic;


namespace LINQ

{
    public class Program
    {
        static void Main(string[] args)
        {

            List<string> videoGames = new List<string>
            {"Call of Duty Modern Warfare 2", "NFL Madden 2023", "NBA 2K 2023", "Call of The Wild", "Farming Simulator 2022" };

            IEnumerable<string> lengthVideoGameNames = videoGames.OrderBy(name => name.Length);

            foreach (var name in lengthVideoGameNames)
            {
                Console.WriteLine(name);
            }

                

            
            
               
            
        }
    }
}
