using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

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

                        Console.WriteLine("Path to desktop: " + pathToDesktop);
            */

            //Ch7 - More about objects

            /*            string text = "This is the last day of our acquaintance";

                        //Outputs of what can be done with string objects
                        Console.WriteLine("Original text: " + text);
                        Console.WriteLine("Number of characters: " + text.Length);
                        Console.WriteLine("In uppercase: " + text.ToUpper());
                        Console.WriteLine("Does it contain word \"last\"? " 
                            + text.Contains("last"));
            */

            /*            //Converting numbers to different formats
                        double amount = 1234.56;
                        double anotherAmt = 789;
                        int wholeNum = 1234567;
                        double decimalNum = 1234567.89;

                        //Formatted outputs
                        Console.WriteLine("Separating thousands and millions + money to cents");
                        Console.WriteLine(amount.ToString("N2")); //N means thousand separation is required
                        Console.WriteLine(anotherAmt.ToString("N2")); //2 or 0 denote the numebr of decimal places in the output
                        Console.WriteLine(wholeNum.ToString("N0"));

                        //Localization objects
                        CultureInfo czech = new CultureInfo("cs-CZ");
                        CultureInfo american = new CultureInfo("en-US");

                        //Localized output
                        Console.WriteLine("Whole number - Czech: " + wholeNum.ToString("N0", czech));
                        Console.WriteLine("Whole number - American: " + wholeNum.ToString("N0", american));


                        Console.WriteLine("Whole number - Czech: " + decimalNum.ToString("N2", czech));
                        Console.WriteLine("Whole number - American: " + decimalNum.ToString("N2", american));
             */
            //Ch8 - Input

            //Console.Write does not transfer the cursor to the next line

            //Calculating Date of Birth
            /*          Console.Write("Enter your year of birth: ");
                        string input = Console.ReadLine();
                        int enteredYear = Convert.ToInt32(input);

                        DateTime today = DateTime.Today;
                        int thisYear = today.Year;

                        int age = thisYear - enteredYear;

                        Console.WriteLine("This year you are/will be: " + age);
             */
            //Handling invalid input
            /*            try
                        {
                            Console.Write("Enter 1. number: ");
                            string input1 = Console.ReadLine();
                            int num1 = Convert.ToInt32(input1);

                            Console.Write("Enter 2. number: ");
                            string input2 = Console.ReadLine();
                            int num2 = Convert.ToInt32(input2);

                            int result = num1 + num2;

                            Console.WriteLine("Sum of entered number is: " + result);
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Incorrect input - cannot calculate");
                        }
            */
            // Ch9 - Numbers 

            /*            //AMERICAN
                        CultureInfo american = new CultureInfo("en-US");
                        try
                        {
                            //Input 
                            Console.Write("Enter American decimal number: ");
                            string input = Console.ReadLine();
                            double number = Convert.ToDouble(input, american);

                            //Output
                            Console.WriteLine("You have entered " + number);

                        }
                        catch (Exception)
                        {
                            //Error Message
                            Console.WriteLine("Incorrect input");
                        }

                        //SPANISH
                        CultureInfo spanish = new CultureInfo("es-ES");
                        try
                        {
                            //Input
                            Console.WriteLine();
                            Console.Write("Enter Spanish decimal number: ");
                            string input = Console.ReadLine();
                            double number = Convert.ToDouble(input, spanish);

                            //Output
                            Console.WriteLine("You have entered: " + number);
                        }
                        catch (Exception)
                        {
                            //Error message
                            Console.WriteLine("Incorrect input");
                        }
            */

            //Handling divisions with intergers
            /*            Console.Write("Enter 1. whole number (dividend): ");
                        string input1 = Console.ReadLine();
                        int number1 = Convert.ToInt32(input1);

                        Console.Write("Enter 2. whole number (divisor): ");
                        string input2 = Console.ReadLine();
                        int number2 = Convert.ToInt32(input2);

                        //Interger Calculations
                        int intergerQuotient = number1 / number2;
                        int remainder = number1 % number2;

                        //"Normal" Calculations with decimals
                        double number1double = number1;
                        double number2double = number2;
                        double normalQuotient = number1double / number2double;

                        //Alternatively
                        double normalQuotientAlt = (double)number1 / (double)number2;

                        //Outputs
                        Console.WriteLine("----------------");
                        Console.WriteLine("Interger quotient: " + intergerQuotient
                            + " with remainder " + remainder);
                        Console.WriteLine("\"Normal\" quotient: " + normalQuotient);
                        Console.WriteLine("\"Normal\" quotient(alernatively): " + normalQuotientAlt);
            */

            /*            //Math Rounding
                        double num1 = 1234.567;
                        double num2 = 9.876;

                        //Number rounding
                        double roundedNum1 = Math.Round(num1, 2); //2 = two decimal places

                        //Rounding for output only
                        string outputRounded2 = num2.ToString("N2");

                        Console.WriteLine(roundedNum1);
                        Console.WriteLine(outputRounded2);
            */
            /*           //More complicated rounding
                       double amount = 1234.562;

                       //To dollars 
                       double nearest = Math.Round(amount);
                       double alwaysUp = Math.Ceiling(amount);
                       double alwaysDown = Math.Floor(amount);

                       Console.WriteLine();
                       Console.WriteLine("To Dollars:");
                       Console.WriteLine("Nearest: " + nearest);
                       Console.WriteLine("Always Down: " +alwaysDown);
                       Console.WriteLine("Always Up: " +alwaysUp);

                       //To Cents
                       nearest = Math.Round(amount, 2);
                       alwaysUp = Math.Ceiling(100 * amount) / 100;
                       alwaysDown = Math.Floor(100 * amount) / 100;

                       Console.WriteLine();
                       Console.WriteLine("To Cents:");
                       Console.WriteLine("Nearest: " + nearest);
                       Console.WriteLine("Always Down: " + alwaysDown);
                       Console.WriteLine("Always Up: " + alwaysUp);

                       //To hundreds of dollars
                       nearest = 100 * Math.Round(amount / 100);
                       alwaysDown = 100 * Math.Floor(amount / 100);
                       alwaysUp = 100 * Math.Ceiling(amount / 100);

                       Console.WriteLine();
                       Console.WriteLine("To hundreds of dollars:");
                       Console.WriteLine("Nearest: " + nearest);
                       Console.WriteLine("Always Down: " + alwaysDown);
                       Console.WriteLine("Always Up: " + alwaysUp);
           */
            //Ch11 - Calculations with Dates

            try
            {
                // Text input of date
                Console.Write("Enter date: ");
                string input = Console.ReadLine();
                // Conversion to DateTime object
                DateTime enteredDate = Convert.ToDateTime(input);
                // Some calculations
                DateTime followingDay = enteredDate.AddDays(1);
                DateTime previousDay = enteredDate.AddDays(-1);
                // Outputs
                Console.WriteLine();
                Console.WriteLine("Entered day : " + enteredDate.
                ToLongDateString());
                Console.WriteLine("Following day: " + followingDay.
                ToLongDateString());
                Console.WriteLine("Previous day : " + previousDay.
                ToLongDateString());

                //Extracting Quarter of entered date
                int enteredMonth = enteredDate.Month;
                int enteredYear = enteredDate.Year;

                int quarter = (enteredMonth + 2) / 3;

                Console.WriteLine("Quarter of Entered Date: " + quarter);

            }
            catch (Exception)
            {
                // Treating incorrect input
                Console.WriteLine("Incorrect input");
            }

            //Use TimeSpan object to do timespan calculations between two dates

            //Waiting for Enter
            Console.ReadLine();

        }
    }
}
