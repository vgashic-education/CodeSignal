using System;

namespace RotateImage {
    class RotateImage {
        static void Main(string[] args) {

            int[][] a = new int[3][];

            a[0] = new[] { 1, 2, 3 };
            a[1] = new[] { 4, 5, 6 };
            a[2] = new[] { 7, 8, 9 };

            rotateImage(a);

        }


        static int[][] rotateImage(int[][] a) {

            int n = a[0].Length;
            int[][] res = new int[n][];


            for (int i = 0; i < n; i++) {

                var arrTmp = a[i];
                res[i] = new int[n];

                for (int j = 0; j < n; j++) {

                    res[i][j] = a[n-1-j][i];

                }
            }

            return res;

        }
    }
}
