using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouSourceSkillTest.Abstracts;
using YouSourceSkillTest.Models;

namespace YouSourceSkillTest.SortStrategies
{
    public class QuickSort : SortStrategyBase
    {
        public override SortResult Sort(SortDto sortDto)
        {
            return new SortResult()
            {
                Result = DoQuickSort(sortDto.TextToSort)
            };
        }

        #region Private Methods
        private string DoQuickSort(string word)
        {
            var letters = word.Where(x => !x.Equals(' ')).ToList();
            ProcessQuickSortRecursive(letters, 0, letters.Count() - 1);
            return string.Join("", letters);
        }
        private void ProcessQuickSortRecursive(List<char> letters, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int pivot = Partition(letters, startIndex, endIndex);

                if (pivot > 1)
                {
                    ProcessQuickSortRecursive(letters, startIndex, pivot - 1);
                }
                if (pivot + 1 < endIndex)
                {
                    ProcessQuickSortRecursive(letters, pivot + 1, endIndex);
                }
            }
        }
        private int Partition(List<char> letters, int startIndex, int endIndex)
        {
            int pivot = letters[startIndex];
            while (true)
            {

                while (letters[startIndex] < pivot)
                {
                    startIndex++;
                }

                while (letters[endIndex] > pivot)
                {
                    endIndex--;
                }

                if (startIndex < endIndex)
                {
                    if (letters[startIndex] == letters[endIndex]) return endIndex;

                    var temp = letters[startIndex];
                    letters[startIndex] = letters[endIndex];
                    letters[endIndex] = temp;
                }
                else
                {
                    return endIndex;
                }
            }
        }
        #endregion
    }
}
