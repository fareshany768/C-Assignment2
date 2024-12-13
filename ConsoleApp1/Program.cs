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
            Console.Write("Enter base and exponent separated by space: ");
            string[] powerInput = Console.ReadLine().Split();
            int baseNum = int.Parse(powerInput[0]);
            int exp = int.Parse(powerInput[1]);
            Console.WriteLine(Math.Pow(baseNum, exp));
            #endregion
        }
    }
}
