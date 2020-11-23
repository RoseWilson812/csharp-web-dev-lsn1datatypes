using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string aliceLC = alice.ToLower();
            Console.WriteLine("Enter a search word");
            string searchWord = Console.ReadLine();
            int wordLength = searchWord.Length;
            int index = alice.IndexOf(searchWord);
            if (index < 0)
            {
                string searchWordLC = searchWord.ToLower();
                index = aliceLC.IndexOf(searchWordLC);
                if (index < 0)
                {
                    Console.WriteLine("Search word not found");
                } else
                {
                    Console.WriteLine("Search word '" + searchWordLC + "' " + "found at index " + index + " for a length of " + wordLength );
                    Console.WriteLine(alice.Remove(index, wordLength));
                }
            } else
            {
                Console.WriteLine("Search word '" + searchWord + "' " + "found at index " + index + " for a length of " + wordLength);
                Console.WriteLine(alice.Remove(index, wordLength));
            }
        }
    }
}
