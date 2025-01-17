using System;

namespace TaskD4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> listNumbers = new List<int>();
            char choice;


            do
            {
                Console.WriteLine("========================");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Diplay mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Search for a number");
                Console.WriteLine("C - Clear the List");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("========================");
                Console.Write("Enter your choice: ");
                choice = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                switch (choice)
                {
                    case 'P':
                        if (listNumbers.Count == 0)
                        {
                            Console.WriteLine("======= Output ========");
                            Console.WriteLine("[ ] The List is empty!");
                        }
                        else
                        {
                            Console.WriteLine("======= Output ========");
                            Console.Write("[ ");
                            for (int i = 0; i < listNumbers.Count; i++)
                            { Console.Write(listNumbers[i] + " "); }
                            Console.WriteLine("]");;
                        }
                        break;

                    case 'A':
                        Console.Write("Enter an integer to add to the list: ");
                        if (int.TryParse(Console.ReadLine(), out int result))
                        {
                            listNumbers.Add(result);
                            Console.WriteLine("======= Output ========");
                            Console.WriteLine($"{result} is added to the list");
                        }
                        else
                        {
                            Console.WriteLine("======= Output ========");
                            Console.WriteLine("Please Enter an Integer value!");
                        }
                        break;
                    case 'M':
                        if (listNumbers.Count == 0)
                        {
                            Console.WriteLine("======= Output ========");
                            Console.WriteLine("Unable to calculate mean - No Data!");
                        }
                        else
                        {
                            double sumation = 0;
                            for (int i = 0; i < listNumbers.Count; i++)
                            {
                                sumation += listNumbers[i];
                            }
                            double meanValue = sumation / listNumbers.Count;
                            Console.WriteLine("======= Output ========");
                            Console.WriteLine($"Mean of the numbers = {meanValue}");
                        }
                        break;
                    case 'S':
                        if (listNumbers.Count == 0)
                        {
                            Console.WriteLine("======= Output ========");
                            Console.WriteLine("Unable to determine the smallest number - list is empty!");
                        }
                        else
                        {
                            int smallNumber = listNumbers[0];
                            for (int i = 0; i < listNumbers.Count; i++)
                            {
                                if ( listNumbers[i]< smallNumber)
                                    smallNumber = listNumbers[i];
                            }
                            Console.WriteLine("======= Output ========");
                            Console.WriteLine($"The smallest number is: {smallNumber}");
                        }
                        break;
                    case 'L':
                        if (listNumbers.Count == 0)
                        {
                            Console.WriteLine("======= Output ========");
                            Console.WriteLine("Unable to determine the largest number - list is empty!");
                        }
                        else
                        {
                            int largeNumber = listNumbers[0];
                            for (int i = 0; i < listNumbers.Count; i++)
                            {
                                if (listNumbers[i] > largeNumber)
                                    largeNumber = listNumbers[i];
                            }
                            Console.WriteLine("======= Output ========");
                            Console.WriteLine($"The largest number is: {largeNumber}");
                        }
                        break;
                    case 'F':
                        if (listNumbers.Count == 0)
                        {
                            Console.WriteLine("======= Output ========");
                            Console.WriteLine("Couldn't find the number - list is empty!");
                        }
                        else
                        {
                            Console.Write("Enter the number to search: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            int numberIndex = -1;
                            for(int i = 0;i < listNumbers.Count;i++)
                            {
                                if (num == listNumbers[i])
                                {
                                    numberIndex = i;
                                    break;
                                }
                            }
                            Console.WriteLine("======= Output ========"); 
                            if (numberIndex != -1) 
                            { 
                                Console.WriteLine($"Needed number found at index: {numberIndex}");
                            } else
                            { 
                                Console.WriteLine("Number not found in the list."); 
                            }
                        }
                        break;
                    case 'C':
                        if (listNumbers.Count == 0)
                        {
                            Console.WriteLine("======= Output ========");
                            Console.WriteLine("list is already empty!");
                        }
                        else
                        {
                            listNumbers.Clear();
                            Console.WriteLine("======= Output ========");
                            Console.WriteLine("The list is cleared");
                        }
                        break;
                    case 'Q':
                        Console.WriteLine("======= Output ========");
                        Console.WriteLine("Good Bye!");
                        break;
                    default:
                        Console.WriteLine("======= Output ========");
                        Console.WriteLine("Unknown selection, please try again");
                        break;

                }

            } while (choice != 'Q');

            Console.ReadKey();
        }
    }
}
