namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num % 3 == 0 && num % 4 == 0 ? "Yes" : "No");

            #endregion
        }
    }
}
