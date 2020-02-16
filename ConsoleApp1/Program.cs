using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();

            Console.WriteLine("enter done to exit");

            int firstNameRow = 1;
            int lastNameRow = 2;

            string firstName = "";
            string lastName = "";
            bool enteringPeople = true;

            while (enteringPeople)
            {

                Console.Clear();

                var originalForegroundColor = Console.ForegroundColor;

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.ForegroundColor = originalForegroundColor;
                WriteText("Press ENTER after each input", 0, 5, false);
                WriteText("Leave inputs empty and press ENTER to exit", 0, 6, false);

                WriteText("Last name", 0, lastNameRow, false);
                WriteText("First name", 0, firstNameRow, false);

                Console.SetCursorPosition(12, firstNameRow);
                firstName = Console.ReadLine();

                Console.SetCursorPosition(12, lastNameRow);
                lastName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
                {

                    Regex regex = new Regex("[ ]{2,}", RegexOptions.None);

                    personList.Add(new Person() { FirstName = Regex.Replace(firstName, @"\s+", " "), LastName = lastName.Replace("\t", " ") });
                }
                else
                {
                    enteringPeople = false;
                }
            }

            if (personList.Count >0)
            {
                Console.Clear();
                Console.WriteLine("People entered:");
                personList.ForEach(person => Console.WriteLine($"{person.FirstName} {person.LastName}"));                
            }
            else
            {
                Console.WriteLine("No names have been added");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }

        Person PromptForName()
        {
            return new Person();
        }

        /// <summary>
        /// Write a string to a specific location on the screen
        /// </summary>
        /// <param name="value">String to print usually "*" or "@"</param>
        /// <param name="positionLeft">The x position,  This is modulo divided by the window.width, which allows large numbers, ie feel free to call with large loop counters</param>
        /// <param name="positionTop"></param>
        /// <param name="restorePosition">Move to original position prior to calling this procedure</param>
        protected static void WriteText(string value, int positionLeft, int positionTop = 1, bool restorePosition = true)
        {
            int originalRow = Console.CursorTop;
            int originalCol = Console.CursorLeft;

            int width = Console.WindowWidth;
            

            try
            {
                positionLeft = positionLeft % width;

                Console.SetCursorPosition(positionLeft, positionTop);
                Console.Write(value);

                if (restorePosition)
                {
                    Console.SetCursorPosition(originalRow, originalCol);
                }

            }
            catch (Exception)
            {
                Console.Write(value);
            }
        }
    }

    class Person
    {
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
