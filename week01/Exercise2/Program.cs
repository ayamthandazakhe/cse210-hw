using System;


using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

     
        if (percentage < 0 || percentage > 100)
        {
            Console.WriteLine("Invalid percentage. Please enter a number between 0 and 100.");
        }
        else
        {
          
            string letter;

            if (percentage >= 90)
            {
                letter = "A";
            }
            else if (percentage >= 80)
            {
                letter = "B";
            }
            else if (percentage >= 70)
            {
                letter = "C";
            }
            else if (percentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

          
            if (percentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course!");
            }
            else
            {
                Console.WriteLine("Keep working hard! You can do better next time.");
            }

         
            string sign = "";
            int lastDigit = percentage % 10;

            if (letter == "A")
            {
                if (lastDigit < 3)
                {
                    sign = "-";
                }
            }
            else if (letter == "F")
            {
                sign = "";
            }
            else
            {
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }

         
            Console.WriteLine($"Your grade is: {letter}{sign}");
        }
    }
}
