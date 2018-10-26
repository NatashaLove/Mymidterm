using System;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Natalia Love (CIS2023)

/*
 * This is the mid-term project/exam.
 * 
 * This project/exam is designed to showcase your understanding of basic programming principles.
 * At this time, the project is not being used to determine your ability in generating your own
 * algorithms. You will be able to follow the directions below and write this program. After each
 * set of directions, there will be a single-line comment block with a series of dashes. It will
 * look similar to the lines below:
 * 
 * /* Create an integer variable named number and assign it an initial value of 42.
 *  * /
 * // -----------------------------------------------------------------------------------
 * 
 * // -----------------------------------------------------------------------------------
 * 
 * While not required, it is recommended that you write your portions of code between these lines,
 * as seen below:
 * 
 * /* Create an integer variable named number and assign it an initial value of 42.
 *  * /
 * // -----------------------------------------------------------------------------------
 * int number = 42;
 * // -----------------------------------------------------------------------------------
 * 
 * Although you are welcome to use your notes, I encourage you to at least try each step of the
 * project on your own - trying to recall what you have learned and practiced in class and on your
 * own.
 * 
 * This program's premise is simple: it will ask the user for the number of people you want to ask
 * about. The program will then ask the user for the age of each of these people. From this, the
 * program will calculate the total and average age of the group in both years and days. The pro-
 * gram will also determine who the oldest and youngest persons are and then display all of the
 * above information.
 * 
 * The following concepts will be on display:
 *      * generating output - weeks 1 and 2
 *      * declaring variables - week 2
 *      * accepting user input - weeks 2 and 3
 *      * conditionals - week 3
 *      * loops - week 4
 *      * arrays - week 5
 *      * methods - week 6
 * 
 * I will not be requiring the use of advanced methods in this assignment; however, some extra
 * credit may be available for those who attempt advanced method calls and apply them properly.
 * 
 * Note: It is recommended, though not required, to write the user-created methods first. Though
 * there are only two of these proposed by the project, you are welcome to create additional ones
 * if you feel they would work better. Also, remember that all methods at this time must be
 * declared as "static".
 * 
 * Also note: There will be some chances for extra credit possible on this project. These will be
 * noted by ECP (Extra Credit Possibility) with a number. However, I will not provide the
 * algorithms for these opportunities. If you wish to try for the extra credit, I expect you to
 * think through those concepts on your own.
 * 
 * ECP #8: Adjust this program, so it asks the user if they would like to continue, and continue
 * to loop through the program until they want to quit.
 * 
 * ECP #9: Finish this assignment without using my pre-written algoritms to receive some bonus
 * points. I will know if you used my algorithm or not.
 * 
 * ECP #10: I will write this program with all possible extra credit possibilties before class.
 * Any student who submits a working assignment that meets all of the basic requirements prior to
 * me finishing the project will receive a 50% bonus on the assignment.
 */

namespace midterm
{
    class Program
    {
        /* Create a static method that accepts an integer and returns an integer. This method
         * accepts an age and returns the number of days. To determine the number of days, you
         * will multiply the age of the person by 365 and return that value.
         * You are free to call this method whatever you want, but you should name it something
         * that will let you know what the method does when called. For instance, CalculateDays.
         * Remember there are 365 days in one year.
         *
         * ECP #1: adjust the method to use 365.25 days per year to account for leap years.
         */

        // ---------------------------------------------------------------------------------------
        static double CalculateDays(int years)
        {

            double days;
            days = years * 365.25;
            return days;
        }

        // ---------------------------------------------------------------------------------------

        /* Create a static method that accepts a string and returns an integer. This method
         * accepts the name of the person and then asks the user what that person's age is. This
         * can be done in as little as two steps: the first step would ask the user to enter an
         * age. For the "personal touch", ask the user "how old is this person?" but instead of
         * saying "this person", use the person's name that was passed into the method. The second
         * step of the method is simply to return the Parsed value of the ReadLine(). I will not
         * test for non-numeric or non-integral input, so do not worry about that.
         * 
         * ECP #2: use advanced method concepts to Try to Parse the value entered by the user, 
         * looping until an appropriate answer is given.
         * 
         * ECP #3: make sure the user is entering a valid age. For instance, a person cannot be
         * below zero years old, and there is a likely maximum of maybe 120 or so.
         */

        // ---------------------------------------------------------------------------------------
        static int AboutPerson(string name)
        {
            int ageInt = 120;
            while (0 > ageInt || ageInt >= 120)
            {
                Console.WriteLine("What is the age?");
                string age = Console.ReadLine();
                ageInt = Int32.Parse(age);
                if (0 > ageInt || ageInt >= 120)
                {
                    Console.WriteLine("Invalid age, try again!");
                }

            }
            return ageInt;
            //Console.WriteLine("{0} is {1} years old.", name, ageInt);

        }

        // ---------------------------------------------------------------------------------------

        // The Main() Method


        static void Main(string[] args)
        {
            string nam = null;
            int ag = 0;
            double days = 0;

            Console.WriteLine("What is your name?");
            nam = Console.ReadLine();

            ag = AboutPerson(nam);
            //Console.WriteLine("---------------");
            // Console.WriteLine("test: after the method ABoutPerson..>>");
            // Console.WriteLine("---------------");

            days = CalculateDays(ag);
            // Console.WriteLine("---------------");
            //  Console.WriteLine("test: after the method Calculaing days..>>");
            //  Console.WriteLine("---------------");


            Console.WriteLine("{0} is {1} days old.", nam, days);



            /* Create three arrays. The first array will be an array of strings that will hold the
             * names of the people in the group. The size of the array can be any number of your
             * choosing.
             * 
             * ECP #4: Ask the user how many names he/she would like to enter and set the size of
             * the array to that amount.
             * 
             * ECP #4.1: Use advanced method concepts to Try to Parse the value entered by the
             * user, looping until an appropriate answer is given.
             * 
             * ECP #4.2: Ensure the number is greater than zero.
             */
            // -----------------------------------------------------------------------------------

            string answer = "yes";

            while (answer != "no")
            {

                string y = null;
                int x = -1;

                while (x < 0)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("How many names would you like to enter?");
                    y = Console.ReadLine();
                    x = Int32.Parse(y);
                    if (x < 0)
                    {
                        Console.WriteLine("The number should be more than 0.");
                    }
                }
                string[] names = new string[x];




                // -----------------------------------------------------------------------------------

                /* The second array will hold the ages in years of the people in the group. These will
                 * be whole numbers (integers). The size of the array should be the number entered
                 * above.
                 */
                // -----------------------------------------------------------------------------------
                int[] ages = new int[x];
                // -----------------------------------------------------------------------------------

                /* The third array will hold the ages in days of the people in the group. These will
                 * be whole numbers (integers). The size of the array should be the number entered
                 * above.
                 * 
                 * ECP #1: if you chose to attempt ECP #1 from above, this array should no longer be
                 * integers. Adjust the array to hold the number of days to take into account leap
                 * years.
                 */
                // -----------------------------------------------------------------------------------
                double[] ageInDays = new double[x];
                // -----------------------------------------------------------------------------------

                /* Create two accumulation integers. The first will hold the total years, and the
                 * second will hold the total days. These should be initialized to zero upon declara-
                 * tion.
                 * 
                 * ECP #1: if you chose to attempt ECP #1 from above, the second variable will no
                 * longer be integers. Adjust this variable to hold the number of days to take into
                 * account leap years.
                 */
                // -----------------------------------------------------------------------------------
                int totalYears = 0;
                double totalDays = 0;
                // -----------------------------------------------------------------------------------

                /* Create two integer variables that will hold the array indexes of the oldest and the
                 * youngest persons in the group. These should be initialized to zero upon declara-
                 * tion.
                 */
                // -----------------------------------------------------------------------------------
                int youngIndex = 0;
                int oldIndex = 0;


                // -----------------------------------------------------------------------------------

                /* Create two integer variables that will hold the ages of the oldest and the youngest
                 * persons in the group. These should be initialized in a manner that will make sure
                 * the first person will be able to set both the highest and lowest ages. For
                 * instance, the oldest person will likely be more than 0 years old, so zero could be
                 * the initial value of the oldest age, since it will be adjusted to an actual age
                 * after the first person's information is entered. Likewise, the youngest person will
                 * likely be under 1,000 years old, so 1,000 could be the initial value of the
                 * youngest age, since the first person will be bringing this down to a more
                 * "realistic" value.
                 * 
                 * ECP #5: Set the oldest age variable to the smallest possible integer value and the
                 * youngest age variable to the largest possible integer value.
                 */
                // -----------------------------------------------------------------------------------
                int youngAge = 130;
                int oldAge = 0;
                // -----------------------------------------------------------------------------------

                /* Create a loop. The loop's initialization clause will be to create an incremental
                 * variable and set it equal to zero. The continuation condition will be as long as
                 * the incrementer is less than the Length of the names array. The incremental
                 * statement will increment the incremental variable by one.
                 * 
                 * The first thing this loop will do is ask the user for the name of a person in the
                 * group. This will be stored in the array of names at the index. Next, the program
                 * will set the age of that person to the array of ages at the index by calling the
                 * AboutPerson method defined above. Next, the program will Calculate the number of Days in
                 * the age of the person and set that value to the array of days at the index.
                 * 
                 * The program should then accumulate the number of years to the total years variable
                 * and accumulate the number of days to the total days variable.
                 * 
                 * Finally, the program should compare the age of the person to the youngest and
                 * oldest people in the group. If the person is younger than the currently youngest
                 * person, assign the value of the incrementer variable to the youngest person
                 * variable and assigned the value of the age array at the incrementer index should be
                 * assigned to the youngest age variable. The same - yet in opposite - should be done
                 * if the person is older than the current oldest age.
                 * 
                 * This ends the loop.
                 */
                // -----------------------------------------------------------------------------------
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine("What is the name of {0} person?", i + 1);
                    names[i] = Console.ReadLine();

                    //Console.WriteLine("What is the age of {0} person?", i + 1);
                    ages[i] = AboutPerson(nam);
                    ageInDays[i] = CalculateDays(ages[i]);
                    totalYears += ages[i];
                    totalDays += ageInDays[i];
                    if (youngAge > ages[i])
                    {
                        youngAge = ages[i];
                        youngIndex = i;
                    }
                    if (oldAge < ages[i])
                    {
                        oldAge = ages[i];
                        oldIndex = i;
                    }

                }
                // -----------------------------------------------------------------------------------

                /* Create a second loop using the same conditions outlined above. The loop will state
                 * the name and age in both years and days of each person. 
                 * 
                 * ECP #6: Display the names and ages so they will line up cleanly when displayed. For
                 * instance, the name could always be 15 characters, left aligned, and the ages could
                 * be an appropriate number of characters and right-aligned.
                 */
                // -----------------------------------------------------------------------------------
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine("\t{0}'s age is {1,2} years or {2,10} days", names[i], ages[i], ageInDays[i]);

                }
                // -----------------------------------------------------------------------------------

                /* Write three additional lines of output. The first will display the total and aver-
                 * age ages of the group in years. The second will dispaly the total and average ages
                 * of the group in days. The third will display the names of the oldest and youngest
                 * persons of the group.
                 * 
                 * ECP #7: Display the first two lines, so they line up in a clean manner when
                 * displayed.
                 */
                // -----------------------------------------------------------------------------------
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("The total age of the group is {0,4} years and the average age of the group is {1,4} years.", totalYears, totalYears / x);
                Console.WriteLine("The total age of the group in DAYS is {0,10} and the average age of the group in DAYS is {1,10}.", totalDays, totalDays / x);
                Console.WriteLine("The oldest person is {0} and the youngest person is {1}.", names[oldIndex], names[youngIndex]);

                Console.WriteLine("Would you like to check another group?");
                answer = Console.ReadLine();
                if (answer != "yes" && answer != "no")
                {
                    Console.WriteLine("Answer: yes or no!");
                    Console.WriteLine("Would you like to check another group?");
                    answer = Console.ReadLine();
                }
            }


            // -----------------------------------------------------------------------------------

            /* Ask the user to press any key to exit and then wait for a keystroke before exiting
             * the program.
             */
            // -----------------------------------------------------------------------------------

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
            // -----------------------------------------------------------------------------------


        }
    }
}
