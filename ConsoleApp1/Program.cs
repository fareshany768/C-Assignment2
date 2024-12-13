using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /* Console.Write("Enter a number: ");
             int num = int.Parse(Console.ReadLine());
             Console.WriteLine(num % 3 == 0 && num % 4 == 0 ? "Yes" : "No"); */

            #endregion
            #region Q2
            /* Console.Write("Enter a number: ");
             int number = int.Parse(Console.ReadLine());
             Console.WriteLine(number < 0 ? "negative" : "positive"); */
            #endregion
            #region Q3
            /*  Console.Write("Enter three numbers separated by spaces: ");
             string[] inputs = Console.ReadLine().Split();
             int a = int.Parse(inputs[0]), b = int.Parse(inputs[1]), c = int.Parse(inputs[2]);
             Console.WriteLine($"Max element = {Math.Max(a, Math.Max(b, c))}");
             Console.WriteLine($"Min element = {Math.Min(a, Math.Min(b, c))}"); */

            #endregion
            #region Q4
            /* Console.Write("Enter a number: ");
            int evenOdd = int.Parse(Console.ReadLine());
            Console.WriteLine(evenOdd % 2 == 0 ? "Even" : "Odd"); */


            #endregion
            #region Q5
            /* Console.Write("Enter a character: ");
             char ch = char.ToLower(Console.ReadLine()[0]);
             Console.WriteLine("aeiou".Contains(ch) ? "vowel" : "consonant");
            */
            #endregion
            #region Q7
            /* Console.Write("Enter a number: ");
            int tableNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
                Console.WriteLine($"{tableNum} x {i} = {tableNum * i}"); */

            #endregion
            #region Q9
            /* Console.Write("Enter base and exponent separated by space: ");
             string[] powerInput = Console.ReadLine().Split();
             int baseNum = int.Parse(powerInput[0]);
             int exp = int.Parse(powerInput[1]);
             Console.WriteLine(Math.Pow(baseNum, exp)); */
            #endregion
            #region Q10

            /* Console.Write("Enter marks of five subjects separated by spaces: ");
             string[] marksInput = Console.ReadLine().Split();
             int[] marks = Array.ConvertAll(marksInput, int.Parse);
             int total = 0;
             foreach (var mark in marks) total += mark;
             double average = total / 5.0;
             double percentage = average;
             Console.WriteLine($"Total marks = {total}\nAverage Marks = {average}\nPercentage = {percentage}"); */

            #endregion
            #region Q11
            /* Console.Write("Enter month number: ");
            int month = int.Parse(Console.ReadLine());
            int days = month switch
            {
                2 => 28,
                4 or 6 or 9 or 11 => 30,
                _ => 31
            };
            Console.WriteLine($"Days in Month: {days}"); */
            #endregion
            #region Q17
            /* Console.Write("Enter three points (x1 y1 x2 y2 x3 y3): ");
             string[] points = Console.ReadLine().Split();
             int x1 = int.Parse(points[0]), y1 = int.Parse(points[1]);
             int x2 = int.Parse(points[2]), y2 = int.Parse(points[3]);
             int x3 = int.Parse(points[4]), y3 = int.Parse(points[5]);
             bool collinear = (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);
             Console.WriteLine(collinear ? "Points are collinear" : "Points are not collinear"); */

            #endregion
            #region Q18
            /* Console.Write("Enter time taken for task in hours: ");
             double time = double.Parse(Console.ReadLine());
             if (time >= 2 && time <= 3) Console.WriteLine("Highly Efficient");
             else if (time > 3 && time <= 4) Console.WriteLine("Increase Speed");
             else if (time > 4 && time <= 5) Console.WriteLine("Training Needed");
             else Console.WriteLine("Leave the Company"); */

            #endregion
            #region Q21
            // number2 will change , number1 still same
            /* int number1 = 10, number2 = number1;
            number2 = 20;
            Console.WriteLine($"number1: {number1}, number2: {number2}"); */



            #endregion
            #region Q22
            /*
            int x = 5;
            int y = 7;
            Point p1, p2;
            p1 = new Point(5, 8);
            p2 = new Point(7, 10);
            Console.WriteLine(p2);
            Console.WriteLine(p1);
            p2 = p1;
            Console.WriteLine(p2);
            Console.WriteLine(p1);  
            */


            #endregion
            #region Q23
            //A value 1 will be assigned to d
            #endregion
        }
    }
}
