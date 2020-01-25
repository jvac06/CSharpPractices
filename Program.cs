using System;

namespace CSharpPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiple output 
            Console.WriteLine("First line \r\nSecond line");

            //Specifying "Enter" in a more human form
            Console.WriteLine("First line" + Environment.NewLine + "Second line");

            //Text containing a quote
            Console.WriteLine("The letter started so sweet: \"My Darling\"");

            //Unicode characters, in this case Greek beta
            Console.WriteLine("If the font knows, here is Greek beta: \u03B2");

            //Backslashes themselves need to be doubled
            Console.WriteLine("Path to desktop on my computer: " + "C:\\Users\\jesid\\Desktop");

            //Bob Dylan...
            Console.WriteLine(@"
            Yes, and how many times 
            can a man turn his head
            and pretend
            that he just doesn't see?
            ");  //note @ also switches off escape sentences, useful when writting filepath lines


            //Special attention needed when mixing texts with numbers!
            Console.WriteLine(@"
Senior math test
================
            
One and one is:");
            Console.WriteLine("a) " + 1 + 1);
            Console.WriteLine("b) " + (1 + 1));
            Console.WriteLine("c) " + "mostly fun");

            //Waiting for Enter
            Console.ReadLine();
        }
    }
}
