using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    public class Functions
    {
        /// <summary>
        /// Function to get a number from the user then check its count from the list that 
        /// is also provided by the user.
        /// </summary>
        public void CountOfNumbers()
        {
            int userNumber;

            while (true)
            {
                // get the number for which user want to check the count
                Console.Write("Enter the number to get its count : ");
                string userInput = Console.ReadLine();
                try
                {
                    userNumber = Convert.ToInt32(userInput);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Your value is too large.");
                }
            }

            // Create a list 
            int count = 0;

            while (true)
            {
                Console.Write("Enter the number for the list or done to exit the list : ");
                string listInput = Console.ReadLine();

                if (listInput.ToLower() == "done")
                {
                    Console.WriteLine("Your list is completed");
                    break;
                }

                try
                {
                    int number = Convert.ToInt32(listInput);
                    if (number == userNumber)
                        count++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid Input.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: The value is too large");
                }
            }


            // Display the count
            Console.WriteLine("The count of your number {0} : {1}", userNumber, count);
        }

        /// <summary>
        /// This function is to compare two lists and then create a new list that 
        /// contain the elements that are not present in second list.
        /// </summary>
        public void SequenceOfValues()
        {
            // get input for the first list
            Console.Write("Enter the values for first-list (separated by space) : ");
            List<string> firstInputList = Console.ReadLine().Split(' ').ToList();

            // get input for the second list
            Console.Write("Enter the values for second-list (separated by space) : ");
            List<string> secondInputList = Console.ReadLine().Split(' ').ToList();

            List<string> result = new List<string>();

            foreach (string input in firstInputList)
            {
                // checking if input is present in second list
                if (!secondInputList.Contains(input))
                {
                    // add element to result
                    result.Add(input);
                }
            }

            string finalList = string.Join(" , ", result);


            if (result.Count == 0)
            {
                Console.WriteLine("All the values of first list matches with second list.");
            }
            else
            {
                Console.WriteLine("Final List : {0}", finalList);
            }
        }

        /// <summary>
        /// This function take minimum and maximum index of a list from the user then 
        /// calculate and display the length, sum and minimum and maximum value from the 
        /// user provided list.
        /// </summary>
        public void GetRange()
        {
            try
            {
                // get minimum index from user
                Console.Write("Enter minimum index : ");
                int minIndex = Convert.ToInt32(Console.ReadLine());

                // get maximum index from user
                Console.Write("Enter maximum index : ");
                int maxIndex = Convert.ToInt32(Console.ReadLine());

                List<int> userList = new List<int>();

                Console.WriteLine("Enter the number of the list or done to exit the list.");

                while (true)
                {
                    Console.Write("Enter number: ");
                    string userInput = Console.ReadLine();

                    if (userInput.ToLower() == "done")
                    {
                        Console.WriteLine("Your list is completed");
                        break;
                    }

                    int number = Convert.ToInt32(userInput);
                    userList.Add(number);
                }


                // Ensure minIndex and maxIndex are within the range of the list
                minIndex = Math.Max(0, minIndex);
                maxIndex = Math.Min(userList.Count - 1, maxIndex);

                if (minIndex <= maxIndex)
                {
                    int count = maxIndex - minIndex + 1;
                    List<int> range = userList.GetRange(minIndex, count);

                    //Calculate and display the result 
                    if (range.Count > 0)
                    {
                        Console.WriteLine("Length of the list : {0}", range.Count);
                        Console.WriteLine("Minimum Value of list : {0}", range.Min());
                        Console.WriteLine("Maximum value of list : {0}", range.Max());
                        Console.WriteLine("Sum of all the values: {0}", range.Sum());
                    }

                    else
                    {
                        Console.WriteLine("The sliced range is empty.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid range. Minimum index should be less than or equal to the maximum index.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input. Please enter a valid integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Input exceeds the valid range.");
            }
        }


        /// <summary>
        /// This function take sequence as a  input from the user and then categorizes 
        /// them into positive even number or positive odd number or negative even number 
        /// or negative odd number
        /// </summary>
        public void TypeOfNumber()
        {
            // get the sequence from the user
            Console.WriteLine("Enter sequence of number (separated by space) : ");
            string userSequence = Console.ReadLine();

            int positiveOddNumbers = 0;
            int positiveEvenNumbers = 0;
            int negativeOddNumbers = 0;
            int negativeEvenNumbers = 0;
            int zeroCount = 0;

            string[] numbers = userSequence.Split(' ');

            // check the number and categorizes it accordingly
            foreach (string number in numbers)
            {
                try
                {
                    int num = Convert.ToInt32(number);

                    if (num % 2 == 0)
                    {
                        if (num > 0)
                        {
                            positiveEvenNumbers++;
                        }
                        else if (num < 0)
                        {
                            negativeEvenNumbers++;
                        }
                    }
                    else
                    {
                        if (num > 0)
                        {
                            positiveOddNumbers++;
                        }
                        else if (num < 0)
                        {
                            negativeOddNumbers++;
                        }
                    }

                    if (num == 0)
                        zeroCount++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input {0}. Please enter a valid number.", number);
                }
            }

            // Display the count of each type 
            Console.WriteLine("The number of positive odd number : {0}", positiveOddNumbers);
            Console.WriteLine("The number of positive even number : {0}", positiveEvenNumbers);
            Console.WriteLine("The number of negative odd number : {0}", negativeOddNumbers);
            Console.WriteLine("The number of negative even number : {0}", negativeEvenNumbers);
            Console.WriteLine("The number of zeros : {0}", zeroCount);
        }
    }
}
