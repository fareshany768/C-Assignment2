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
            Console.Write("Enter a character: ");
            char ch = char.ToLower(Console.ReadLine()[0]);
            Console.WriteLine("aeiou".Contains(ch) ? "vowel" : "consonant");

            #endregion
        }
    }
}
