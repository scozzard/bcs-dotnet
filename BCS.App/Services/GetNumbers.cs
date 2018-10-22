using System.Collections.Generic;

using BCS.App.Model;

namespace BCS.App.Services
{
    public class GetNumbers
    {
        /// <summary>
        /// This method returns a list of numbers from 1 to 100 along with some associated output text.
        ///
        /// The contents on the associated output text is determined by whether it meets the following criteria:
        ///
        /// - Where a number is a multiple of 3, set “multiple of 3” as the output text.
        /// - where a number ends in a 6, set “ends in 6” as the output text.
        /// - Where a number is both a multiple of 3 and ends in 6, set “multiple of 3, ends in 6” as the output text.
        ///
        /// This way I've written this method is very simple, but it could be made more extensible in a few ways. For example,
        /// the limit (100), the output multiple (3) and the "ends in" digit (6) could all be method parameters with default
        /// values. These parameters could even be set to arrays so that output could be rendered for various multipliers/ending digits.
        /// I've decided to stick to the script and not go down that rabbit hole, as it could turn into quite a long day :).
        /// </summary>
        public static List<NumberWithOutput> GetNumbersWithOutput()
        {
            var output = new List<NumberWithOutput>();

            for (var i = 1; i <= 100; i++)
            {
                var outputSegments = new List<string>();

                if (i >= 3 && i % 3 == 0)
                {
                    outputSegments.Add("multiple of 3");
                }

                if (i >= 6 && i % 10 == 6)
                {
                    outputSegments.Add("ends in 6");
                }

                output.Add(new NumberWithOutput(i, string.Join(", ", outputSegments)));
            }

            return output;
        }
    }
}
