using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double Add(double v1, double v2)
        {
            return v1 + v2;

        }

        public static double Subtract(double v1, double v2)
        {
            return v1 - v2;
        }

        public static double Multiply(double v1, double v2)
        {
            return v1 * v2;
        }

        public static double Divide(double v1, double v2)
        {
            return v1 / v2;
        }

        public static double Sum(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static double Minimum(double[] numbers)
        {
            double min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        public static double Maximum(double[] numbers)
        {
            double max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public static double Average(double[] numbers)
        {
            double sum = 0;
            double average = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            average = sum / numbers.Length;

            return average; 
        }
    }
}
