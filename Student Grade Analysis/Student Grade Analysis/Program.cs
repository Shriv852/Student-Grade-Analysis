using System;
using System.Linq;
using System.Collections.Generic;

namespace Student_Grade_Analysis
{
    class Program
    {
        public static List<int> Grades = new List<int>();
        public static void Main()
        {
            
            int amountofgrades = 50;
            
            Random rnd = new Random();
            

            for (int i = 0; i < amountofgrades; i++) {
                int randNum = rnd.Next(0, 100);
                
                Grades.Add(randNum);
            }
            bool loop = true;
            while (loop == true) {

                int inputNum = Run();

                if (inputNum == 1) //Display All 50 grades
                    {
                    Console.WriteLine("---------All Grades-----------");
                    
                    for (int i = 0; i < Grades.Count; i++)
                    {
                        Console.WriteLine(Grades[i]);
                        //Console.WriteLine(i);
                    }
                    Console.WriteLine("----------------------------------");
                }
                if (inputNum == 2)
                {
                    for (int i = 0; i < Grades.Count; i++)
                    {
                        int randNum = rnd.Next(0, 100);

                        Grades[i] = randNum;
                    }
                    Console.WriteLine("Grades Have Been Randomized!");
                }
                if (inputNum == 3) //Find Highest score, lowest score, and average of all scores
                {
                    Console.WriteLine("Highest Grade: " + Grades.Max());
                    Console.WriteLine("Lowest Grade: " + Grades.Min());
                    Console.WriteLine("Average Grade: " + Grades.Average());
                }
                if (inputNum == 4) //Count Honours
                {
                    var honours = Grades.Count(n => n >= 80);
                    Console.WriteLine("Number of Honours: " + honours);
                }
                if (inputNum == 5)
                {
                    for (int i = 0; i < Grades.Count; i++)
                    {
                        Grades.RemoveAll(i => i < 50);
                    }
                    Console.WriteLine("Fail Grades Have been Removed!");
                }
                if (inputNum == 6)
                {
                    Console.WriteLine("Goodbye!");
                    loop = false;
                }
            } //Loop End
        }//Main function End

        public static int Run()
        {
            Console.WriteLine("-------Main Menu---------");
            Console.WriteLine("Press 1 to Display All Grades");
            Console.WriteLine("Press 2 to Randomzie Grades");
            Console.WriteLine("Press 3 to Stats");
            Console.WriteLine("Press 4 to Count Honours");
            Console.WriteLine("Press 5 to Remove Failing");
            Console.WriteLine("Press 6 to Exit");
            Console.WriteLine("--------------------------");

            return Convert.ToInt32(Console.ReadLine());
        }
    } //End of Class
}
