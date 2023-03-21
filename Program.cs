using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           string girl = "Agatha";
           Console.WriteLine("Hello Pretty! My name is " + " " + girl);

            int number = 21;
            Console.WriteLine("This is my brother's age" + " " + number);

            const bool game =true;
        // bool game = false;
            Console.WriteLine(game);

            string firstName = "David";
            string lastName = "Gideon";

            char letter = 'D';
            Console.WriteLine("My name is" + " " + firstName + " "+ lastName + ", i am " + " " + number + ". My favourite letter is " + letter);

            string Salutation;
            if (DateTime.UtcNow.Hour >= 0 && DateTime.UtcNow.Hour < 11)
            {
                Salutation = "Good Morning";
            }
            else if (DateTime.UtcNow.Hour >= 11 && DateTime.UtcNow.Hour < 15)
            {
                Salutation = "Good Afternoon";
            }
            else if (DateTime.UtcNow.Hour >= 15 && DateTime.UtcNow.Hour < 20)
            {
                Salutation = "Good Evening";
            }
            else
            {
                Salutation = "Hello";
            }
            Console.WriteLine(Salutation);
            Console.WriteLine("Can i be your Friend?");
            Console.WriteLine("What's your name?");
            string friendName = Console.ReadLine();
            Console.WriteLine("Hello," + " " + Salutation + " "+ friendName + "! " + "  " + "I'd Love to be your friend too");

            Console.WriteLine("Solving Maths used to be easy until they added alphabet😢");
            int myAge = 21;
            int leapYear = 365;
            int add = myAge * leapYear;
            Console.WriteLine("So i have spent" + " " + myAge + " "  + "years like this??");
            Console.WriteLine("If you spend" + " " + add + "days as a 21years old, how many days would you have spent when you are 50?");
            Console.WriteLine("🙄🙄🙄");
            Console.WriteLine("I don't like maths but let me just try.");
            int aYear = 365;
            int fiftYears = aYear * 50;
            int divison = add - fiftYears;
            Console.WriteLine("Currently, I have spent" + " " + add + " " + "To spend 50years, i multiplied 50 * 365 and that will be" + " " + fiftYears + " " + "." + " Having spent" + " " + add + "" + "already , i guess it will remain" + " " + divison + "days to be 50years");

            string yearDate = "2003-10-27";
            DateTime birthDate = Convert.ToDateTime(yearDate);
            DateTime todayDate = DateTime.Now;
            if (birthDate > todayDate)
            {
                Console.WriteLine("Date of Birth : {0} ", birthDate);
            }
            Console.WriteLine("Today's date is " + " " + todayDate);
            Console.WriteLine("Date of Birth : {0}", birthDate);


            Console.WriteLine(Math.Sqrt(102345));
            


        }

    }
}
