using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            //Chapter 3

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
                        Console.WriteLine("b) " + (1 + 1)); // using variables to represent number expressions can help when combining text & numbers
                        Console.WriteLine("c) " + "mostly fun");*/

            /*          //Chapter 4

                        //Variable for storing numbers (with initial value)
                        int number = -12;

                        //Output of the value of the variable
                        Console.WriteLine("Value of the variable: " + number);

                        // In C# use type 'double' to represent decimal numebrs
                        // these are rounded after approx 15 significant digits

                        //Two logical (Boolean) values
                        bool thePrettiestGirlLovesMe = true;
                        bool iAmHungry = false;

                        //Use exclamation mark to negate logical value
                        bool iAmNotHungry = !iAmHungry;

                        // Output
                        Console.WriteLine("She loves me: " + thePrettiestGirlLovesMe);
                        Console.WriteLine("I am hungry: " + iAmHungry);
                        Console.WriteLine("I am not hungry: " + iAmNotHungry);*/

            //Chapter 5 - Objects groupings of components and even other objects

            /*            // Variable of DateTime type, at first empty
                        DateTime now;

                        //Storing of current date and time into our variable
                        now = DateTime.Now;

                        //Output
                        Console.WriteLine("Now is " + now);

                        //Components of DateTime object
                        int day = now.Day;
                        int month = now.Month;
                        int year = now.Year;
                        int hours = now.Hour;
                        int minutes = now.Minute;
                        int seconds = now.Second;
                        DateTime justDate = now.Date;

                        //Output
                        Console.WriteLine("Day: " + day);
                        Console.WriteLine("Month: " + month);
                        Console.WriteLine("Year: " + year);
                        Console.WriteLine("Hours: "+ hours);
                        Console.WriteLine("Minutes: "+  minutes);
                        Console.WriteLine("Seconds: "+ seconds);
                        Console.WriteLine("Date component: "+ justDate);

                        //Formatting it our way
                        Console.WriteLine("Our output: " + year + ", " + month + "/" +
                            day + " " + hours + " hours " + minutes + " minutes");*/

            //Learning about the Environment Object -info abour computer and OS surroundings

            //Display components of Environment object
            /*   Console.WriteLine("Device name: " + Environment.MachineName);
                 Console.WriteLine("64-bit system: " + Environment.Is64BitOperatingSystem);
                 Console.WriteLine("User name: " + Environment.UserName);*/

            //Ch6 - Using Object Actions

            /* DateTime today = DateTime.Today;

             Console.WriteLine("Today is " + today.ToLongDateString());

             //Tomorrow's date
             DateTime tomorrow = today.AddDays(1);

             Console.WriteLine("I will start learning on " + 
                 tomorrow.ToShortDateString() + ".");

             //Assigning specific date using object constructor
             DateTime dDay = new DateTime(1944, 6, 6);

             Console.WriteLine("D-day was on " + dDay.ToLongDateString());
 */

            /*            //Creating random numbers

                        Random randomNumbers = new Random();

                        //Throwing the dies
                        int num1 = randomNumbers.Next(1, 6+1);
                        int num2 = randomNumbers.Next(1, 6+1);
                        int num3 = randomNumbers.Next(1, 6+1);

                        Console.WriteLine("Thrown numbers: " + num1 + ", " 
                            + num2 + ", " + num3 +"." );*/

            /*            //Finding Path to your desktop
                        string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop;

                        Console.WriteLine("Path to desktop: " + pathToDesktop);*/

            //Ch7 - More about objects

            string text = "This is the last day of our acquaintance";

            //Outputs of what can be done with string objects
            Console.WriteLine("Original text: " + text);
            Console.WriteLine("Number of characters: " + text.Length);
            Console.WriteLine("In uppercase: " + text.ToUpper());
            Console.WriteLine("Does it contain word \"last\"? " 
                + text.Contains("last"));


        }
    }
}
