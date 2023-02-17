using System;

namespace ExtensionMethods
{
    public static class ConsoleExtensions
    {
        public static string RequestString(this string message)
        {
            string output = "";

            while (string.IsNullOrWhiteSpace(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }

        // For converting console readline string to int
        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
        }

        public static int RequestInt(this string message, int minValue, int maxValue)
        {
            return message.RequestInt(true, minValue, maxValue);
        }

        private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0) // min value and max value can be optional parameters
        {
            int output = 0;
            bool isValidInt = false;
            bool withinValidRange = true;

            while (isValidInt == false || withinValidRange == false)
            {
                Console.Write(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);

                if (useMinMax == true)
                {
                    withinValidRange = (output >= minValue && output <= maxValue);
                    //if (output >= minValue && output <= maxValue)
                    //{
                    //    withinValidRange = true;
                    //}
                    //else
                    //{
                    //    withinValidRange = false;
                    //}
                }
            }
            return output;
        }
    }





















}
