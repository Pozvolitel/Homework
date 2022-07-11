using System;

namespace Helper
{
    public class ArrayHelper
    {
        public static int MaxIndex(int[] array)
        {
            if(array == null || array.Length == 0)
            {
                throw new ArgumentException("Empty or null array!");
            }

            int maxIndex = 0;
            for(int i = 1; i < array.Length; i++)
            {
                if(array[maxIndex] < array[i])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public static int MinIndex(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Empty or null array!");
            }

            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[minIndex] > array[i])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int[] GenerateArray(int size)
        {
            if (size <= 0)
            {
                throw new NullReferenceException();
            }

            int[] array = new int[size];
            Random random = new Random();

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            return array;
        }

        public static int Max(int[] array)
        {
            return array[MaxIndex(array)];
        }

        public static int Min(int[] array)
        {
            return array[MinIndex(array)];
        }

        public static void Reverse(int[] array)
        {
            if(array == null)
            {
                throw new NullReferenceException();
            }

            int halfSize = array.Length / 2;
            for (int i = 0; i < halfSize; i++)
            {
                Swap(ref array[i], ref array[array.Length - 1 - i]);
            }
        }

        public static void HalfReverse(int[] array)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }

            int halfSize = array.Length / 2;
            int rightStartPosition = halfSize + array.Length % 2;
            for (int i = 0; i < halfSize; i++)
            {
                Swap(ref array[i], ref array[rightStartPosition + i]);
            }
        }
    }

    public class СycleHelper
    {
        //The user enters number. Find a number that is a mirror image of the sequence of digits of a given number, for example, given the number 123, output 321.
        public static int MirrorReflection(int number)
        {
            int result = 0;
            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
            return result;
        }

        //The user enters number. Find the number of odd digits of this number.
        public static int OddNumber(int a)
        {
            int c = 0;
            while (a != 0)
            {
                if ((a % 10) % 2 != 0)
                {
                    c++;
                }
                a = a / 10;
            }
            return c;
        }

        //The user enters 2 numbers. Find their greatest common divisor using Euclid's algorithm.
        public static int Euclid(int a, int b)
        {
            int nod = 0;

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return nod = a + b;
        }

        //The user enters 1 number(N). Print the Nth number of the fibonacci series.In the fibonacci series, each next number is the sum of the previous two. The first and second are considered equal to 1.
        public static int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        //The user enters 2 numbers(A and B). Print the sum of all numbers from the range A to B that are divisible by 7 without a remainder. (Note that B may be less than A if you type)
        public static int WithoutARemainder(int a, int b)
        {
            int sum = 0;
            if (b > a)
            {
                for (int i = a; b >= i; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            else if (b < a)
            {
                for (int i = b; a >= i; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }

        //The user enters 2 numbers (A and B). Raise the number A to the power of B.
        public static int RaiseTheNumber(int a)
        {
            return Convert.ToInt32(Math.Pow(a, 3));
        }
    }

    public class Lection2Helper
    {
        //1. The user enters 2 numbers (A and B). If A > B, result is A+B, if A=B, result is A * B, if A < B, result is A-B.
        public static int Task1(int a, int b)
        {
            int result = a;
            if (a > b)
            {
                result += b;
            }
            else if (a == b)
            {
                result *= b;
            }
            else
            {
                result -= b;
            }

            return result;
        }

        // 2. The user enters 2 numbers(X and Y). Determine which quarter the point with coordinates(X, Y) belongs to.
        public static int Task2(int x, int y)
        {
            int result = default;
            if (x == 0 || y == 0)
            {
                return result;
            }

            if (x > 0)
            {
                if (y > 0)
                {
                    result = 1;
                }
                else
                {
                    result = 4;
                }
            }
            else
            {
                if (y > 0)
                {
                    result = 2;
                }
                else
                {
                    result = 3;
                }
            }

            return result;
        }

        //3. The user enters 3 numbers (A, B and C). Print them to the console in ascending order.
        public static (int a, int b, int c) Task3(int a, int b, int c)
        {
            if (a > b)
            {
                ArrayHelper.Swap(ref a, ref b);
            }
            if (a > c)
            {
                ArrayHelper.Swap(ref a, ref c);
            }
            if (b > c)
            {
                ArrayHelper.Swap(ref b, ref c);
            }

            return (a, b, c);
        }

        // 4.The user enters 3 numbers(A, B and C). Print to the console the solution(X-values) of the standard form quadratic equation, where AX^2+BX+C=0.
        public static (double x1, double x2) Task4(float a, float b, float c)
        {
            double x1 = double.NaN;
            double x2 = double.NaN;
            double sqrtOfD = Math.Sqrt((b * b) - (4 * a * c));

            if (sqrtOfD >= 0)
            {
                x1 = (-b + sqrtOfD) / (2 * a);
                x2 = (-b - sqrtOfD) / (2 * a);
            }

            return (x1, x2);
        }

        //5. The user enters a two-digit number. Print the capitalization of this number to the console. For example, typing "25" will print "twenty-five" to the console.
        public static string GetCapitalizationOfNumber(int a)
        {
            if (a < 10 || a > 99)
            {
                throw new ArgumentException("invalid input, number must be between 10 and 99!");
            }

            int firstDigit = a / 10;
            int secondDigit = a % 10;

            if (firstDigit != 1)
            {
                return $"{GetDozens(firstDigit)} {GetUnits(secondDigit)}";
            }

            return GetExceptionalNumbers(secondDigit);
        }

        private static string GetExceptionalNumbers(int secondDigit)
        {
            string result = string.Empty;
            switch (secondDigit)
            {
                case 0:
                    result = "ten";
                    break;
                case 1:
                    result = "eleven";
                    break;
                case 2:
                    result = "twelve";
                    break;
                case 3:
                    result = "thirteen";
                    break;
                case 4:
                    result = "fourteen";
                    break;
                case 5:
                    result = "fifteen";
                    break;
                case 6:
                    result = "sixteen";
                    break;
                case 7:
                    result = "seventeen";
                    break;
                case 8:
                    result = "eighteen";
                    break;
                case 9:
                    result = "nineteen";
                    break;
            }

            return result;
        }

        private static string GetUnits(int secondDigit)
        {
            string result = string.Empty;
            switch (secondDigit)
            {
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
            }

            return result;
        }

        private static string GetDozens(int firstDigit)
        {
            string result = string.Empty;
            switch (firstDigit)
            {
                case 2:
                    result = "twenty";
                    break;
                case 3:
                    result = "thirty";
                    break;
                case 4:
                    result = "fourty";
                    break;
                case 5:
                    result = "fifty";
                    break;
                case 6:
                    result = "sixty";
                    break;
                case 7:
                    result = "seventy";
                    break;
                case 8:
                    result = "eighty";
                    break;
                case 9:
                    result = "ninety";
                    break;
            }

            return result;
        }       
    }

    public class Lection1Helper
    {
        //1. The user enters the number of hours, output the number of minutes in that number of hours.
        public static int NubberOfHouse(int nubberOfHouse)
        {
            if(nubberOfHouse <= 0)
            {
                throw new ArgumentException("numbers must be positive and greater than zero!");
            }
            return nubberOfHouse * 60;
        }

        //2. The user enters 2 numbers (A and B). Print the solution (5*A+B^2)/(B-A) to the console.
        public static float Task2(int a, int b)
        {
            return (float)(5 * a + b * b) / (b - a);
        }        

        //4. The user enters 2 numbers (A and B). Print to the console the result of dividing A by B and the division remainder.
        public static (int dividingResult, int divisionResult) Task4(in int a, in int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("numbers must be positive and greater than zero!");
            }

            int dividing = a / b;
            int division = a % b;

            return (dividing, division);
        }

        //5. The user enters 3 non-zero numbers (A, B and C). Print to the console the solution (X value) of the standard linear equation, where A*X+B=C.
        public static float Task5(float a, float b, float c)
        {
            if(a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("numbers must be positive and greater than zero!");
            }

            return (float)Math.Round((c - b) / a, 5);
        }

        //6. The user enters 4 numbers (X1, Y1, X2, Y2) describing the coordinates of 2 points on the coordinate plane. Output the equation of a straight line in the format Y=AX+B passing through these points.
        public static (float a, float b) Task6(float y1, float y2, float x1, float x2)
        {
            float a = (y1 - y2) / (x1 - x2);
            float b = y2 - a * x2;

            return (a, b);
        }

        //7. The variable N stores a natural two-digit number (10-99). Write a program that calculates and displays the sum of the digits of n.
        public static int Task7(int n)
        {
            if (n < 10 || n > 99)
            {
                throw new ArgumentException("invalid input, number must be between 10 and 99!");
            }
            int first = n / 10;
            int second = n % 10;

            return first + second;
        }
    }

    public class Matrix
    {
        public static int[,] GenerateMatrix(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                throw new ArgumentException();
            }

            Random random = new Random();
            int[,] matrix = new int[x, y];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, x * y);
                }
            }

            return matrix;
        }

        public static int MinNumber(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Empty or null array!");
            }

            int minElement = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (minElement > matrix[i, j])
                    {
                        minElement = matrix[i, j];
                    }
                }
            }
            return minElement;
        }

        public static (int MinIndexMatrixRow, int MinIndexMatrix) MinIndex(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Empty or null array!");
            }

            int MinIndexMatrixRow = 0;
            int MinIndexMatrix = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[0, 0] > matrix[i, j])
                    {
                        matrix[0, 0] = matrix[i, j];
                        MinIndexMatrix = j;
                        MinIndexMatrixRow = i;
                    }
                }
            }
            return (MinIndexMatrixRow, MinIndexMatrix);
        }

        public static int MaxNumber(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Empty or null array!");
            }

            int maxElement = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (maxElement < matrix[i, j])
                    {
                        maxElement = matrix[i, j];
                    }
                }
            }
            return maxElement;
        }

        public static (int MaxIndexMatrixRow, int MaxIndexMatrix) MaxIndex(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Empty or null array!");
            }

            int MaxIndexMatrixRow = 0;
            int MaxIndexMatrix = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[0, 0] < matrix[i, j])
                    {
                        matrix[0, 0] = matrix[i, j];
                        MaxIndexMatrix = j;
                        MaxIndexMatrixRow = i;
                    }
                }
            }
            return (MaxIndexMatrixRow, MaxIndexMatrix);
        }

        public static void PreobrMatr(int[,] matrix)
        {
            var size = matrix.GetLength(1);
            for (var i = 0; i < matrix.Length / 2; i++)
            {
                var i1 = matrix.Length - i - 1;

                var temp = matrix[i1 / size, i1 % size];
                matrix[i1 / size, i1 % size] = matrix[i / size, i % size];
                matrix[i / size, i % size] = temp;
            }
        }
       
    }
}
