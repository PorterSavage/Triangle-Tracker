using System;
public class Triangle
{
    public static void Main()
    {
        Console.WriteLine("Enter the length of the first side of your triangle:");
        string firstSide = Console.ReadLine();
        int firstSideNumber = int.Parse(firstSide);
        
        Console.WriteLine("Enter the length of the second side of your triangle:");
        string secondSide = Console.ReadLine();
        int secondSideNumber = int.Parse(secondSide);

        Console.WriteLine("Enter the length of the third side of your triangle:");
        string thirdSide = Console.ReadLine();
        int thirdSideNumber = int.Parse(thirdSide);
        TriangleType(firstSideNumber, secondSideNumber, thirdSideNumber);
    }
    public static void TriangleType(int firstSideNumber, int secondSideNumber, int thirdSideNumber)
    {
        if(firstSideNumber == secondSideNumber && secondSideNumber == thirdSideNumber)
        {
            Console.WriteLine("Your triangle is Equalateral, All sides are equal!");
        }
        else if(firstSideNumber + secondSideNumber < thirdSideNumber || secondSideNumber + thirdSideNumber < firstSideNumber || thirdSideNumber + firstSideNumber < secondSideNumber)
        {
            Console.WriteLine("These sides do not equal a triangle!");
        }
        else if(firstSideNumber == secondSideNumber || secondSideNumber == thirdSideNumber || thirdSideNumber == firstSideNumber)
        {
            Console.WriteLine("Your triangle is Isosceles, two sides are equal!");
        }
        else if(firstSideNumber != secondSideNumber && secondSideNumber != thirdSideNumber)
        {
            Console.WriteLine("Your triangle is Scalene, no sides are equal!");
        }
    }
}