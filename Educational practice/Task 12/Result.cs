using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Result
    {
        string SortingType
        {
            get;
            set;
        }
        string ArrayType
        {
            get;
            set;
        }
        int NumberOfComparisons
        {
            get;
            set;
        }
        public Result() { }
        public Result(string sortings, string arrayType, int comparisons)
        {
            SortingType = sortings;
            ArrayType = arrayType;
            NumberOfComparisons = comparisons;
        }
        public override string ToString()
        {
            return $"{SortingType}, {ArrayType}, {NumberOfComparisons} сравнений";
        }
    }
}
