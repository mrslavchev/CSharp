using System;

namespace Methods
{
    class Methods
    {
        /// <summary>
        /// All static methods are made private, for no public static methods are allowed 
        /// </summary>
        private static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Invalid input!"); //is the corrct way to handle wrong input
            }

            else if ((sideA+sideB > sideC) && (sideB+sideC >sideA) && (sideA+sideC >sideB))  //check if its valid triangle 
            {
                double s = (sideA + sideB + sideC) / 2; //we left it weird like this its Heron's formula for triangle area 
                double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
                return area;
            }

            else
            {
                throw new ArgumentException("Invaid side lengths!"); //otherways we throw exception again
            }
        }

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
                default: throw new ArgumentException("Invalid input!"); //it's very bad practice to miss default case so I added it
            }
        }

        private static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Wrong input!"); //replaced -1 with exception
            }
            Array.Sort(elements); //replaced iteration with the sort method 
            int biggestNum = elements[elements.Length-1]; 
            return biggestNum;
        }
        /// <summary>
        /// Because print as number was such a disaster to handle I rewrote the method
        /// and splitted it by three.
        /// Changed the way it is invoked in Main() as well.
        /// </summary>
        private static string CheckRoundTrip(double number, string format)
        {
            string output = "";
            if (format == "r")
            {
                output = string.Format("{0,8}", number);
                return output;
            }
            else
            {
                throw new ArgumentException("Unknown identifier");
            }
        }

        private static string CheckFixedPoint(double number, string format)
        {
            if (format == "f")
            {
                string output = string.Format("{0:f2}", number);
                return output;
            }

            else
            {
                throw new ArgumentException("Unknown identifier");
            }
        }

        private static string CheckPercent(double number, string format)
        {
            string output = "";
            if (format == "%")
            {
                output = string.Format("{0:p0}", number);
                return output;
            }
            else
            {
                throw new ArgumentException("Unknown identifier");
            }
        }
        /// <summary>
        /// Should just deleted isHorizontal and isVertical, cause CalcDistance method 
        /// has nothing to do with both, but extracted it in a method, it's a bit lame 
        /// imo but works. 
        /// </summary>
        private static double CalcDistance(double x1, double y1, double x2, double y2) 
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }
        private static string IsHorizontalOrVertical(double x1, double y1, double x2, double y2)
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
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            Console.WriteLine(NumberToDigit(5));
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            Console.WriteLine(CheckFixedPoint(1.3, "f"));
            Console.WriteLine(CheckPercent(0.75, "%"));
            Console.WriteLine(CheckRoundTrip(2.30, "r"));
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Is the line horizontal or vertical?\n " + IsHorizontalOrVertical(3, -1, 3, 2.5));
            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";
            
            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";
            
            Console.WriteLine("{0} older than {1} -> {2}",
                stella.FirstName, peter.FirstName, stella.IsOlderThan(stella, peter));
        }
    }
}
