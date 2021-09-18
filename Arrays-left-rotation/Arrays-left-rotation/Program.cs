using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_left_rotation {
    class Program {
        public static List<int> RotateLeft(List<int> a, int d) {
            List<int> result = a;

            for (int i = 0; i < d; ++i) {
                int firstElement = a[0];

                for (int j = 0; j < a.Count - 1; ++j) {
                    result[j] = result[j + 1];
                }

                result[a.Count - 1] = firstElement;
            }

            return result;
        }

        // Input: 1. Number of rotations
        //        2. Array
        static void Main(string[] args) {
            Console.WriteLine("Enter the number of rotations: ");
            int rotationNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the array: ");
            List<int> solutionArray = Console.ReadLine().Split(' ').ToList().Select(tmp => Convert.ToInt32(tmp)).ToList();

            List<int> result = RotateLeft(solutionArray, rotationNumber);
            Console.WriteLine($"Result: {string.Join(" ", result)}");

            Console.Read();
        }
    }
}
