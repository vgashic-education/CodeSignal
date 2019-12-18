using System;

namespace FirstNonRepeatingCharacter {
    class FirstNonRepeatingCharacter {

        /*
        Note: Write a solution that only iterates over the string once and uses O(1) additional memory, since this is what you would be asked to do during a real interview.

        Given a string s consisting of small English letters, find and return the first instance of a non-repeating character in it. If there is no such character, return '_'.

        Example

        For s = "abacabad", the output should be
        firstNotRepeatingCharacter(s) = 'c'.

        There are 2 non-repeating characters in the string: 'c' and 'd'. Return c since it appears in the string first.

        For s = "abacabaabacaba", the output should be
        firstNotRepeatingCharacter(s) = '_'.

        There are no characters in this string that do not repeat.

        Input/Output

        [execution time limit] 3 seconds (cs)

        [input] string s

        A string that contains only lowercase English letters.

        Guaranteed constraints:
        1 ≤ s.length ≤ 105.

        [output] char

        The first non-repeating character in s, or '_' if there are no characters that do not repeat.
        */


        static void Main(string[] args) {

            char res = firstNotRepeatingCharacter("abacabad");

            Console.WriteLine(res);

        }


        static char firstNotRepeatingCharacter(string s) {

            // each position in array represents one lowercase letter
            int[] lettersCount = new int[26];

            char[] str = s.ToCharArray();

            // fill lettersCount array with number of occurences of each letter
            for (int i = 0; i < str.Length; i++) {

                // index of current letter in letterCount array
                // 97 represents ascii code for lowercase a
                int currentLetterIndex = (int)str[i] - 97;

                lettersCount[currentLetterIndex] += 1;

            }

            // find first letter that has count 1 in lettersCount array, and return it
            for (int i = 0; i < str.Length; i++) {

                int currentLetterIndex = (int)str[i] - 97;

                if (lettersCount[currentLetterIndex] == 1) {

                    // if letter with count 1 is found, return it
                    return str[i];
                }
            }

            // if no letters with count 1 is found,
            // the loop will finish, and we should return underscore
            return '_';



        }
    }
}
