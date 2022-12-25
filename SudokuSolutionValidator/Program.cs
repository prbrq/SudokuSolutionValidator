namespace SudokuSolutionValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var goodSudoku1 = new SudokuValidator(
            new int[][]{
                new int[] {7,8,4, 1,5,9, 3,2,6},
                new int[] {5,3,9, 6,7,2, 8,4,1},
                new int[] {6,1,2, 4,3,8, 7,5,9},

                new int[] {9,2,8, 7,1,5, 4,6,3},
                new int[] {3,5,7, 8,4,6, 1,9,2},
                new int[] {4,6,1, 9,2,3, 5,8,7},

                new int[] {8,7,6, 3,9,4, 2,1,5},
                new int[] {2,4,3, 5,6,1, 9,7,8},
                new int[] {1,9,5, 2,8,7, 6,3,4},
            });
            Console.WriteLine(goodSudoku1.IsValid());

            var goodSudoku2 = new SudokuValidator(
            new int[][]{
                new int[] {1,4, 2,3},
                new int[] {3,2, 4,1},

                new int[] {4,1, 3,2},
                new int[] {2,3, 1,4}
            });
            Console.WriteLine(goodSudoku2.IsValid());

            var badSudoku1 = new SudokuValidator(
            new int[][]{
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},

                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},

                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9}
            });
            Console.WriteLine(badSudoku1.IsValid());

            var badSudoku2 = new SudokuValidator(
            new int[][]{
                new int[] {1,2,3,4,5},
                new int[] {1,2,3,4},

                new int[] {1,2,3,4},
                new int[] {1}
            });
            Console.WriteLine(badSudoku2.IsValid());
        }
    }
}