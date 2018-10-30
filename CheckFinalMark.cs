// Manuel Lago
// The program asks the user 3 marks and show the average of them

using System;

public class Exercise1
{
    public static void Main()
    {
        Console.Write("Enter First Mark: ");
        int mark1 = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Enter Second Mark: ");
        int mark2 = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Enter Third Mark: ");
        int mark3 = Convert.ToInt32( Console.ReadLine() );
        
        int average = (mark1 + mark2 + mark3) / 3;
        
        if (( mark1 >= 4 ) && ( mark2 >= 4 ) && ( mark3 >= 4 )
                && ( average >= 5 ))
            Console.WriteLine("The average is: {0}", average);
        else if (( mark1 >= 4 ) && ( mark2 >= 4 ) && ( mark3 >= 4 )
                    && ( average < 5 ))
            Console.WriteLine("The average is: {0}", 4);
        else if (( mark1 > 4 ) || ( mark2 > 4 ) || ( mark3 > 4 )
                    && ( average >= 5 ))
            Console.WriteLine("The average is: {0}", 3);
        else
            Console.WriteLine("The average is: {0}", average);
    }
}
