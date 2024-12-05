namespace Exceptions_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStatement;
            Console.Write("Enter Your Statment : ");
            inputStatement = Console.ReadLine().ToUpper();
            try
            {
                if (!inputStatement.Contains('A') && !inputStatement.Contains('E') && !inputStatement.Contains('I') &&
                    !inputStatement.Contains('O') && !inputStatement.Contains('U'))
                {
                    throw new Exception("Your Statment Doesn't Conatin Vowels");
                }
                else
                {
                    Console.WriteLine($"The Statment is {inputStatement}");
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
