using System;
using System.Text;

namespace IsCryptSolution {
    class Program {
        static void Main(string[] args) {

            string[] crypt = new[] { "AAAAAAAAAAAAAA", "BBBBBBBBBBBBBB", "CCCCCCCCCCCCCC" };

            char[][] solution = new[] {
                new[] {'A', '1'},
                new[] {'B', '2'},
                new[] {'C', '3'},
                //new[] {'E', '5'},
                //new[] {'N', '6'},
                //new[] {'D', '7'},
                //new[] {'R', '8'},
                //new[] {'S', '9'}
            };

            isCryptSolution(crypt, solution);

        }


        static bool isCryptSolution(string[] crypt, char[][] solution) {

            // array that holds crypted values
            double[] cryptedArray = new double[crypt.Length];

            // sum of all elements except last one
            double sum = 0;

            for (int i = 0; i < crypt.Length; i++) {

                string s = crypt[i];

                // replace chars with corresponding number
                for (int j = 0; j < solution.Length; j++) {

                    s = s.Replace(solution[j][0], solution[j][1]);

                }

                // check if there are leading zeroes
                if (s.StartsWith("0") && s != "0") {
                    return false;
                }

                cryptedArray[i] = double.Parse(s);

                // add to sum except if we are on the last element
                if (i < crypt.Length - 1) {
                    sum += cryptedArray[i];
                }
            }

            return sum == cryptedArray[crypt.Length - 1];

        }
    }
}
