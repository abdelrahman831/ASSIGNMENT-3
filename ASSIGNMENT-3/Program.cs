using System;
using System.Numerics;
using System.Runtime.CompilerServices;

class Assignment3
{

    public int getMaxInt(int n1,int n2,int n3)
    {
        int[] nums= new int[3];
        nums[0] = n1;
        nums[1] = n2;
        nums[2] = n3;
        int max = 0;

        for(int i = 0; i < nums.Length; i++)
        {

            if (nums[i]> max)
            {
                max = nums[i];
            }
        }


        return max;
    }

    public int getMinInt(int n1, int n2, int n3)
    {
        int[] nums = new int[3];
        nums[0] = n1;
        nums[1] = n2;
        nums[2] = n3;
        int min = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {

            if (nums[i] < min)
            {
                min = nums[i];
            }
        }


        return min;
    }

    static void Main(string[] args)
    {
        #region Check divisibility by 3 and 4
        // Write a program that takes a number from the user then prints yes if that number can be divided by 3 and 4 otherwise print no.
        // Example (1)
        // Input: 12 
        // Output: Yes
        // Example (2)
        // Input: 9 
        // Output: No
        //Console.WriteLine("Enter a number ");
        //int inputNumber = int.Parse(Console.ReadLine());
        //if(inputNumber % 3 == 0 && inputNumber % 4 == 0)
        //{
        //    Console.WriteLine("yes");
        //}
        //else
        //{
        //    Console.WriteLine("no");
        //}

        #endregion

        #region Check positive or negative number
        // Write a program that allows the user to insert an integer then print negative if it is a negative number otherwise print positive.
        // Example (1)
        // Input: -5
        // Output: negative
        // Example (2)
        // Input: 10
        // Output: positive
        //Console.WriteLine("Enter a number ");
        //int inputNumber = int.Parse(Console.ReadLine());
        //if(inputNumber > 0)
        //{
        //    Console.WriteLine("positive");
        //}
        //else
        //{
        //    Console.WriteLine("negative");
        //}

        #endregion

        #region Find max and min element
        // Write a program that takes 3 integers from the user then prints the max element and the min element.
        // Example (1)
        // Input: 7, 8, 5
        // Output:
        // max element = 8
        // min element = 5
        // Example (2)
        // Input: 3, 6, 9
        // Outputs:
        // max element = 9
        // min element = 3
        //Console.WriteLine("Insert first integer number");
        //int FirstinputNumber = int.Parse(Console.ReadLine());
        //
        //Console.WriteLine("Insert second integer number");
        //int SecondinputNumber = int.Parse(Console.ReadLine());
        //
        //Console.WriteLine("Insert third integer number");
        //int ThirdinputNumber = int.Parse(Console.ReadLine());
        //
        //
        //var mc = new Assignment3();
        //
        //int maxInt = mc.getMaxInt(FirstinputNumber, SecondinputNumber, ThirdinputNumber);
        //int minInt = mc.getMinInt(FirstinputNumber, SecondinputNumber, ThirdinputNumber);
        //
        //
        //Console.WriteLine($"max: {maxInt} \n min: {minInt}");



        #endregion

        #region Check even or odd
        // Write a program that allows the user to insert an integer number then checks if the number is even or odd.

        //Console.WriteLine("Enter a number ");
        //int inputNumber = int.Parse(Console.ReadLine());
        //if(inputNumber % == 0)
        //{
        //    Console.WriteLine("even");
        //}
        //else
        //{
        //    Console.WriteLine("odd");
        //}
        #endregion

        #region Check vowel or consonant
        // Write a program that takes a character from the user then if it is a vowel (a, e, i, o, u) then print "vowel", otherwise print "consonant".
        // Example (1)
        // Input: O
        // Output: vowel
        // Example (2)
        // Input: b
        // Output: consonant

        //Console.WriteLine("Enter a char");
        //char inputChar = Console.ReadKey().KeyChar;
        //Console.WriteLine("");
        //
        //if (inputChar.ToString().ToLower() == "a" || inputChar.ToString().ToLower() == "e" || inputChar.ToString().ToLower() == "i" || inputChar.ToString().ToLower() == "o" || inputChar.ToString().ToLower() == "u")
        //{
        //    Console.WriteLine("vowel");
        //}
        //else
        //{
        //    Console.WriteLine("consonant");
        //}
        #endregion

        #region Print numbers from 1 to n
        // Write a program that allows the user to insert an integer then prints all numbers between 1 to that number.
        // Example 
        // Input: 5
        // Output: 1, 2, 3, 4, 5

        //Console.WriteLine("Enter a number");
        //int num = int.Parse(Console.ReadLine());
        //string res = "";
        //
        //for (int i = 1; i <= num;i++)
        //{
        //    if (i>0 && i < num)
        //    {
        //        res = res + i+" ,";
        //    }
        //    else
        //    {
        //        res = res + i;
        //
        //    }
        //
        //}
        //
        //Console.WriteLine($"{res}");
        #endregion

        #region Multiplication table
        // Write a program that allows the user to insert an integer then prints a multiplication table up to 12.
        // Example
        // Input: 5
        // Outputs: 5 10 15 20 25 30 35 40 45 50 55 60

        //Console.WriteLine("Enter a number");
        //int num = int.Parse(Console.ReadLine());
        //string res = "";
        //
        //for (int i = 1; i <= 12;i++)
        //{
        //    res = res + " " + i * num;
        //}
        //Console.WriteLine($"{res}");

        #endregion

        #region Print all even numbers
        // Write a program that allows the user to insert a number then prints all even numbers between 1 and that number.
        // Example:
        // Input: 15
        // Output: 2 4 6 8 10 12 14

        //Console.WriteLine("Enter a number");
        //int num = int.Parse(Console.ReadLine());
        //string res = "";
        //
        //for (int i = 1; i <= num;i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        res = res + " " + i;
        //    }
        //}
        //Console.WriteLine($"{res}");

        #endregion

        #region Calculate power of a number
        // Write a program that takes two integers then prints the power.
        // Example:
        // Input: 4 3
        // Output: 64
        // Hint: How to calculate 4^3 = 4 * 4 * 4 = 64
        //Console.WriteLine("Base:");
        //int baseNum = int.Parse(Console.ReadLine());
        //
        //Console.WriteLine("Power:");
        //int powNum = int.Parse(Console.ReadLine());
        //int res = 1;
        //
        //for (int i = 1; i <= powNum; i++)
        //{
        //    res = res * baseNum;
        //}
        //Console.WriteLine( $"{res}");

        #endregion

        #region Calculate marks
        // Write a program to enter marks of five subjects and calculate total, average, and percentage.
        // Example
        // Input: - Enter Marks of five subjects: 95 76 58 90 89
        // Output: Total marks = 408
        //         Average marks = 81
        //         Percentage = 81

        //Console.WriteLine("Enter MArks");
        //float mark1 = float.Parse(Console.ReadLine());
        //float mark2 = float.Parse(Console.ReadLine());
        //float mark3 = float.Parse(Console.ReadLine());
        //float mark4 = float.Parse(Console.ReadLine());
        //float mark5 = float.Parse(Console.ReadLine());
        //float totalMarks = mark1 + mark2 + mark3 + mark4 + mark5;
        //float avg = totalMarks / 5;
        //float prc = totalMarks * 100 / 500;
        //Console.WriteLine($"TOTAL: {totalMarks}\nAverage: {avg}\nPercentage: {prc}");




        #endregion

        #region Days in month
        // Write a program to input the month number and print the number of days in that month.
        // Example
        // Input: Month Number: 1
        // Output: Days in Month: 31


        //Console.Write("Enter the month number (1-12): ");
        //int month = int.Parse(Console.ReadLine());
        //
        //int days = month switch
        //{
        //    1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
        //    4 or 6 or 9 or 11 => 30,
        //    2 => 28, // Consideriamo solo anni non bisestili
        //    _ => -1 // Valore non valido
        //};
        //
        //if (days == -1)
        //{
        //    Console.WriteLine("Invalid month number. Please enter a value between 1 and 12.");
        //}
        //else
        //{
        //    Console.WriteLine($"Days in Month: {days}");
        //}


        #endregion

        #region Simple calculator
        // Write a program to create a simple calculator.

        //13*4/2+34+2-12
        //string inputstring = "13 * 4 / 2 + 34 + 2 - 12+24*34+45*67/78";
        //inputstring = inputstring.Trim();
        //string[] calc= new string[inputstring.Length+3];
        //string temp= "";
        //int conata = 0;
        //
        //for(int i = 0; i < inputstring.Length; i++)
        //{
        //
        //    if (inputstring[i] == '*' || inputstring[i] == '+' || inputstring[i] == '-' || inputstring[i] == '/')
        //    {
        //        conata += 2;
        //        calc[conata] = inputstring[i].ToString();
        //        calc[conata - 1] = temp;
        //        temp = "";
        //        
        //    }
        //    else
        //    {
        //        temp = temp + inputstring[i];
        //        if(i == inputstring.Length - 1)
        //        {
        //            conata++;
        //            calc[conata] = temp;
        //        }
        //    }
        //
        //}
        //
        //double result;
        //
        //for (int i = 0; i < calc.Length; i++)
        //{
        //    if (calc[i] == "*")
        //    {
        //        result = int.Parse(calc[i - 1]) * int.Parse(calc[i + 1]);
        //        calc[i] = null;
        //        calc[i-1] = null;
        //        calc[i+1] = result.ToString();
        //
        //    }
        //    if (calc[i] == "/")
        //    {
        //        result = int.Parse(calc[i - 1]) / int.Parse(calc[i + 1]);
        //        calc[i] = null;
        //        calc[i - 1] = null;
        //        calc[i + 1] = result.ToString();
        //    }
        //}
        //
        //string[] calc2 = new string[calc.Length];
        //int contaCalc = 0;
        //string[] calc3 = new string[calc.Length];
        //int contaCalc2 = 0;
        //
        //
        //
        //for (int i = 0; i < calc.Length; i++)
        //{
        //    if (calc[i] != null)
        //    {
        //        calc2[contaCalc] = calc[i];
        //        contaCalc++;
        //
        //    }
        //}
        //
        //
        //for (int i = 0; i < calc2.Length; i++)
        //{
        //    if (calc2[i] == "+")
        //    {
        //        result = int.Parse(calc2[i - 1]) + int.Parse(calc2[i + 1]);
        //        calc2[i] = null;
        //        calc2[i - 1] = null;
        //        calc2[i + 1] = result.ToString();
        //        //Console.WriteLine(i);
        //        //Console.WriteLine($"{int.Parse(calc[i - 1])} {int.Parse(calc[i + 1])}");
        //
        //    }
        //    if (calc2[i] == "-")
        //    {
        //        result = int.Parse(calc2[i - 1]) - int.Parse(calc2[i + 1]);
        //        calc2[i] = null;
        //        calc2[i - 1] = null;
        //        calc2[i + 1] = result.ToString();
        //    }
        //}
        //
        //for (int i = 0; i < calc2.Length; i++)
        //{
        //    if (calc2[i] != null)
        //    {
        //        calc3[contaCalc2] = calc2[i];
        //        contaCalc2++;
        //
        //    }
        //}
        //
        //
        //for (int i = 0; i < calc3.Length; i++)
        //{
        //    if (calc3[i] != null)
        //    {
        //        Console.WriteLine(calc3[i]);
        //
        //    }
        //}


        #endregion

        #region Reverse a string
        // Write a program to allow the user to enter a string and print the reverse of it.
        //Console.Write("Enter a string: ");
        //string inputString = Console.ReadLine();
        //char[] charArray = inputString.ToCharArray();
        //Array.Reverse(charArray);
        //Console.WriteLine("Reversed string: " + new string(charArray));
        #endregion



        #region Reverse an integer
        // Write a program to allow the user to enter an integer and print the reverse of it.
        #endregion

        #region Find prime numbers in a range
        // Write a program in C# Sharp to find prime numbers within a range of numbers.
        // Test Data:
        // Input starting number of range: 1
        // Input ending number of range : 50
        // Expected Output:
        // The prime numbers between 1 and 50 are:
        // 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
        //Console.Write("Input starting number of range: ");
        //int start = int.Parse(Console.ReadLine());
        //Console.Write("Input ending number of range: ");
        //int end = int.Parse(Console.ReadLine());
        //
        //Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);
        //
        //for (int i = start; i <= end; i++)
        //{
        //    bool isPrime = true;
        //
        //    if (i < 2) isPrime = false;
        //    for (int j = 2; j <= Math.Sqrt(i); j++)
        //    {
        //        if (i % j == 0)
        //        {
        //            isPrime = false;
        //            break;
        //        }
        //    }
        //
        //    if (isPrime) Console.Write(i + " ");
        //}
        //Console.WriteLine();

        #endregion

        #region Convert decimal to binary
        // Write a program in C# Sharp to convert a decimal number into binary without using an array.
        // Test Data:
        // Enter a number to convert: 25
        // Expected Output:
        // The binary of 25 is 11001.

        //Console.Write("Enter a number to convert: ");
        //int decimalNumber = int.Parse(Console.ReadLine());
        //string binary = "";
        //
        //while (decimalNumber > 0)
        //{
        //    binary = (decimalNumber % 2) + binary;
        //    decimalNumber /= 2;
        //}
        //
        //Console.WriteLine("The binary representation is: " + binary);


        #endregion

        #region Check collinearity of points
        // Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
        //
        //Console.Write("Enter x1, y1: ");
        //int x1 = int.Parse(Console.ReadLine());
        //int y1 = int.Parse(Console.ReadLine());
        //
        //Console.Write("Enter x2, y2: ");
        //int x2 = int.Parse(Console.ReadLine());
        //int y2 = int.Parse(Console.ReadLine());
        //
        //Console.Write("Enter x3, y3: ");
        //int x3 = int.Parse(Console.ReadLine());
        //int y3 = int.Parse(Console.ReadLine());
        //
        //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
        //{
        //    Console.WriteLine("The points are collinear.");
        //}
        //else
        //{
        //    Console.WriteLine("The points are not collinear.");
        //}


        #endregion

        #region Evaluate worker efficiency
        // Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows:
        // - If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
        // - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
        // - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
        // - If the worker takes more than 5 hours, they are required to leave the company.
        // To calculate the efficiency of a worker, the time taken for the task is obtained via user input.
        //
        //Console.Write("Enter time taken (in hours): ");
        //double timeTaken = double.Parse(Console.ReadLine());
        //
        //if (timeTaken >= 2 && timeTaken <= 3)
        //{
        //    Console.WriteLine("Highly efficient");
        //}
        //else if (timeTaken > 3 && timeTaken <= 4)
        //{
        //    Console.WriteLine("Increase your speed");
        //}
        //else if (timeTaken > 4 && timeTaken <= 5)
        //{
        //    Console.WriteLine("You need training to improve speed");
        //}
        //else if (timeTaken > 5)
        //{
        //    Console.WriteLine("You are required to leave the company");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input");
        //}
        #endregion


        #region Print identity matrix
        // Write a program that prints an identity matrix using a for loop. In other words, take a value n from the user and show the identity matrix of size n * n.
        #region Print identity matrix
        // Program to print identity matrix
        //Console.Write("Enter the size of the matrix: ");
        //int size = int.Parse(Console.ReadLine());
        //
        //for (int i = 0; i < size; i++)
        //{
        //    for (int j = 0; j < size; j++)
        //    {
        //        if (i == j)
        //            Console.Write("1 ");
        //        else
        //            Console.Write("0 ");
        //    }
        //    Console.WriteLine();
        //}


        #endregion

        #region Sum of array elements
        // Write a program in C# Sharp to find the sum of all elements of the array.
        //Console.Write("Enter the number of elements: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] array = new int[n];
        //int sum = 0;
        //
        //Console.WriteLine("Enter the elements:");
        //for (int i = 0; i < n; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //    sum += array[i];
        //}
        //
        //Console.WriteLine("Sum of all elements: " + sum);
        #endregion


    }
}