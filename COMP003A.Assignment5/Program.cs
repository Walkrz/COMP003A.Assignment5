
namespace COMP003A.Assignment5
{
    class Program
    {
        // Author: Zachary Walker
        // Course: COMP003A-L01
        // Purpose: Code for Assignment 5

        static void Main(string[] args)
        {
            PrintSeparator("            Triangle Section");
            Console.Write("Enter a character for the triangle: ");
            char triangleCharacter = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a positive whole number: ");
            int triangleSize = Convert.ToInt32(Console.ReadLine());

            IsoscelesTriangleBuilder(triangleCharacter, triangleSize);

            PrintSeparator("            Favorite Characters Section");

            CharacterInfo("Spawn", 1993);
            CharacterInfo("Ted Mosby", 1979);
            CharacterInfo("Ultimate Warrior", 1960);
            CharacterInfo("Marvin the Martian", 1949);
            CharacterInfo("Himura Kenshin", 1850);

            Console.ReadKey();
        }

        /// <summary>
        /// Outputs 50 asterisks in the console.
        /// </summary>
        static void PrintSeparator()
        {
            Console.WriteLine(new string('*', 50));
        }

        /// <summary>
        /// Outputs the specified string parameter and separators in the console.
        /// </summary>
        /// <param name="separator">The string to be displayed as a separator.</param>
        static void PrintSeparator(string separator)
        {
            PrintSeparator(); // Call the parameterless PrintSeparator() method
            Console.WriteLine(separator);
            PrintSeparator(); // Call the parameterless PrintSeparator() method
        }

        /// <summary>
        /// Builds an isosceles triangle using the specified character and size.
        /// </summary>
        /// <param name="inputCharacter">The character used to build the triangle.</param>
        /// <param name="size">The size of the triangle.</param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }

            for (int i = size - 1; i >= 1; i--)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }
        }

        /// <summary>
        /// Calculates and returns the age based on the provided birth year.
        /// </summary>
        /// <param name="year">The birth year.</param>
        /// <returns>The calculated age.</returns>
        static int AgeCalculator(int year)
        {
            return DateTime.Now.Year - year;
        }

        /// <summary>
        /// Outputs the name and calculated age of a character based on the birth year.
        /// </summary>
        /// <param name="name">The name of the character.</param>
        /// <param name="birthYear">The birth year or first appearance year of the character.</param>
        static void CharacterInfo(string name, int birthYear)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"{name} turns {age} this year!");
        }
    }
}
