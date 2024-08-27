namespace LapDay1CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question => 1
            //Console.Write("Enter Please First Number  (It must be a decimal number or an integer) : ");
            //if (decimal.TryParse(Console.ReadLine(), out decimal number1))
            //{
            //    Console.Write("Enter Please the type of operation   Choose From (* , + , - , /) : ");
            //    if (char.TryParse(Console.ReadLine(), out char typeOperation))
            //    {
            //        Console.Write("Enter Please Second Number  (It must be a decimal number or an integer) : ");
            //        if (decimal.TryParse(Console.ReadLine(), out decimal number2))
            //        {
            //            switch (typeOperation)
            //            {
            //                case '*':
            //                    Console.WriteLine(Calculator.Multiply(number1, number2));
            //                    break;
            //                case '/':
            //                    Calculator.Divide(number1, number2);
            //                    Console.WriteLine(Calculator.Divide(number1, number2));
            //                    break;
            //                case '-':
            //                    Console.WriteLine(Calculator.Subtract(number1, number2));
            //                    break;
            //                case '+':
            //                    Console.WriteLine(Calculator.Add(number1, number2));
            //                    break;

            //                default:
            //                    Console.WriteLine("Error, Must Be Choose From (* , + , - , /)");
            //                    break;
            //            }
            //        }
            //    }
            //}
            #endregion

            #region Question => 2

            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (IsCompleteNumber(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
        }

        static bool IsCompleteNumber(int number)
        {
            int sumOfFactors = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sumOfFactors += i;
                }
            }

            return sumOfFactors == number;
        }
    }
}
