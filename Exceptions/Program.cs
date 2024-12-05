namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfList;
            Console.Write("enter total number of the List: ");
            countOfList = int.Parse(Console.ReadLine());
            int number;
            List<int> listOfIntegers = new List<int>(countOfList);
            for (int i = 0; i < countOfList; i++)
            {
                Console.Write("enter number:");
                number = int.Parse(Console.ReadLine());
                try
                {
                    for (int j = 0; j < listOfIntegers.Count; j++)
                    {
                        if (number == listOfIntegers[j])
                        {
                            throw new Exception();
                        }
                    }
                    listOfIntegers.Add(number);
                }
                catch (Exception e)
                {
                    Console.WriteLine("this number is already excist");
                    i--;
                }
            }
            Console.Write("[ ");
            foreach (int item in listOfIntegers)
            {
                Console.Write($"{item} ");
            }
            Console.Write("]");
        }
    }
}






        


  

