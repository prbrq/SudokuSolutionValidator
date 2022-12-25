using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolutionValidator
{
    class SudokuValidator
    {
        public int Size { get; private set; }
        public double Step { get; private set; }
        public int[][] Table { get; private set; }

        public SudokuValidator(int[][] sudokuData)
       {
            Size = sudokuData.Length;
            Step = Math.Sqrt(Size);
            Table = sudokuData;
        }

        public bool IsValid()
        {
            if (Size < 0 || unchecked(Step != (int)Step))
                return false;
            if (Math.Pow(Size, 2) != (Table.SelectMany(x => x).Count()))
                return false;
            for (var i = 0; i < Size; i++)
                for (var j = 0; j < Size; j++)
                {
                    int number = Table[i][j];
                    if (number < 1 || number > Size)
                        return false;
                    if (number < 1)
                        return false;
                    if (!HorizontalCheck(i, j, number) || !VerticalCheck(i, j, number) || !LittleSquareCheck(i, j, number))
                        return false;
                }
            return true;
        }

        private bool HorizontalCheck(int i, int j, int number)
        {
            if (Array.LastIndexOf(Table[i], number) != j)
                return false;
            return true;
        }

        private bool VerticalCheck(int i, int j, int number)
        {
            for (var row = i + 1; row < Size; row++)
                if (Table[row][j] == number)
                    return false;
            return true;
        }

        private bool LittleSquareCheck(int i, int j, int number)
        {
            int step = (int)Step;
            int row = i / step;
            int column = j / step;
            int rowStart = row * step;
            int rowEnd = rowStart + step;
            int columnStart = column * step;
            int columnEnd = columnStart + step;
            List<int> littleSquare = new List<int>();
            for (var littleSquareI = rowStart; littleSquareI < rowEnd; littleSquareI++)
                for (var littleSquareJ = columnStart; littleSquareJ < columnEnd; littleSquareJ++)
                {
                    littleSquare.Add(Table[littleSquareI][littleSquareJ]);
                }
            return littleSquare.Count(squareNumber => squareNumber == number) == 1;
        }
    }
}
