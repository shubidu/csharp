using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SplitSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string mySentence = Console.ReadLine();
            string[] sentenceArray = mySentence.Split();
            foreach (var word in sentenceArray)
                Console.WriteLine(word);
            Console.ReadLine();
        }
    }
}
