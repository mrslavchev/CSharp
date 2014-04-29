using System;

namespace Methods
{
    // Comments are exceptionally explaining what I refactored and how, not exlpaining the code.
    public class Methods
    {
        /*All static methods are made private, for no public static methods are allowed*/
        private static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                //The corrct way to handle wrong input.
                throw new ArgumentException("Side lengths can not be negative numbers!"); 
            }
            else if ((sideA+sideB > sideC) && (sideB+sideC > sideA) && (sideA+sideC > sideB)) 
            {
                // Heron's s formula for triangle area
                double halfPerimeter = (sideA + sideB + sideC) / 2;
                double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

                return area;
            }
            else
            {
                throw new ArgumentException("Invaid side lengths!");
            }
        }

        /// <summary>
        /// Returns the text value of an imput digit.
        /// </summary>
        /// <param name="number">Integer digit in range 0-9</param>
        /// <returns>String representation of a digit.</returns>
        private static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                // It's very bad practice to miss default case so I added it.
                default: throw new ArgumentException("Invalid input!Must be integer from 0 to 9."); 
            }
        }

        /// <summary>
        /// Finds max element in an array if integers.
        /// </summary>
        /// <param name="elements">Array of integers.</param>
        /// <returns>Integer with the greatest value.</returns>
        private static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Input should have at least 1 element!");
            }

            //Replaced iteration with the sort method.
            Array.Sort(elements); 
            int maxNumber = elements[elements.Length-1]; 

            return maxNumber;
        }

        /// <summary>
        /// Prints number with specific formatting.
        /// </summary>
        /// <param name="number">Double number to be formatted.</param>
        /// <param name="formatIdentifier">String identifier for formatting.</param>
        /// <returns>Number as formatted string.</returns>
        private static string FormatNumberAsString(double number, string formatIdentifier)
        {
            string output = string.Empty;
            string printingPattern = string.Empty;
            switch (formatIdentifier)
            {
                case "r":
                    printingPattern = "{0,8}";
                    break;
                case "f":
                    printingPattern = "{0:f2}";
                    break;
                case "%":
                    printingPattern = "{0:p0}";
                    break;
                default:
                    throw new AggregateException("Unknown identifier.");
            }

            output = string.Format(printingPattern, number);
            return output;
        }

        /// <summary>
        /// Calculates distance between 2 points.
        /// </summary>
        /// <param name="x1">Double x coordinate of first point.</param>
        /// <param name="y1">Double y coordinate of first point.</param>
        /// <param name="x2">Double x coordinate of second point.</param>
        /// <param name="y2">Double y coordinate of second point.</param>
        /// <returns>Double distance between points.</returns>
        private static double CalculateDistance(double x1, double y1, double x2, double y2) 
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        private static string FindLineOrientation(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                return "horizontal";
            }
            else if (y1 == y2)
            {
                return "vertical";
            }
            else
            {
                throw new ArgumentException("Input don't meet method criteria");
            }
        }

        /// <summary>
        /// testing all methods 
        /// </summary>
        static void Main()  
        {
            // Method tests.
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            Console.WriteLine(NumberToDigit(5));
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            Console.WriteLine(FormatNumberAsString(1.3, "f"));
            Console.WriteLine(FormatNumberAsString(0.75, "%"));
            Console.WriteLine(FormatNumberAsString(2.30, "r"));
            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Is the line horizontal or vertical?\n " + FindLineOrientation(3, -1, 3, 2.5));
            
            // Student tests.
            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";          
            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";
            Console.WriteLine("{0} older than {1} -> {2}",
                stella.FirstName, peter.FirstName, stella.IsOlderThan(peter));
        }
    }
}
