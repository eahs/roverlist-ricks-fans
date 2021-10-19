using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
     
            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words
			RoverList<string> WordList = new RoverList<string>();
			string[] words = ["zero", "one", "two", "three", "four", 
							  "five", "six", "seven", "eight", "nine", 
							  "ten", "eleven" "twelve", "thirteen", 
							  "fourteen", "fifteen"];
			for (string word in words)
			{
				WordList.Add(word);
			}


            // TODO:  Print out the list
			WordList.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
			string input = "empty";
			while (input !- "done")
			{
				Console.WriteLine("Enter a word to add to the list. Enter done to finish");
				WordList.Add(Console.ReadLine());
			}
			// TODO:  Print out the list
			WordList.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
			input = "empty";
			while (input != "done:)
			{
				Console.WriteLine("Enter a word to add to the FRONT of the list. Enter done to finish");
				WordList.Add(0, Console.ReadLine());
			}
            // TODO:  Print out the list
			WordList.ListNodes();

            // TODO:  Remove every word with an odd length
			for (int i = 0; i < WordList.Count; i++)
			{
				if (WordList.NodeAt(i).data.Length % 2 == 1)
				{
					WordList.RemoveAt(i);
				}
			}
            // TODO:  Print out the list
			WordList.ListNodes();

            // TODO:  Clear the list
			WordList.Clear();

            // TODO:  Print out the list
			WordList.ListNodes();

        }
    }
}
