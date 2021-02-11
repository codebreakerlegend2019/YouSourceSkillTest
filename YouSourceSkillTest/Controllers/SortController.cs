using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YouSourceSkillTest.Enumerations;
using YouSourceSkillTest.Models;

namespace YouSourceSkillTest.Controllers
{
    public class SortController
    {
        #region Public Methods
        public SortResult SortText(SortDto sortDto)
        {
            if (IsTextContainsNumber(sortDto.TextToSort))
                return new SortResult("Text Contain Numbers!!");
            if (string.IsNullOrEmpty(sortDto.SortStrategy.ToString()))
                return new SortResult("No Sorting Strategy Selected");
            if (!Regex.IsMatch(sortDto.TextToSort, @"^[a-zA-Z0-9\s.\?\,\'\;\:\!\-]+$"))
                return new SortResult("Special Character Not Allowed");
            if(sortDto.SortStrategy.Equals(SortStrategy.BUBBLESORT))
                return new SortResult()
                {
                    Result = DoBubbleSort(sortDto.TextToSort.Trim())
                };
            if(sortDto.SortStrategy.Equals(SortStrategy.QUICKSORT))
                return new SortResult()
                {
                    Result = DoQuickSort(sortDto.TextToSort.Trim())
                };
            return new SortResult("Invalid Sort Strategy");
        }
        #endregion
        #region Validation Helper
        private bool IsTextContainsNumber(string text)
        {
            return text.ToList().Any(x => char.IsDigit(x));
        }
        #endregion
        #region BubbleSort
        private string DoBubbleSort(string word)
        {
            var letters = word.Where(x=>!x.Equals(' ')).ToList();
            var letterCount = letters.Count();
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < letterCount - 1; i++)
                {
                    if (letters[i] > letters[i + 1])
                    {
                        char c = letters[i];
                        letters[i] = letters[i + 1];
                        letters[i + 1] = c;
                        swapped = true;
                    }
                }
                letterCount--;
            } while (swapped);

            return string.Join("",letters);
        }
        #endregion
        #region Quick Sort
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

                if (pivot > 1) {
                    ProcessQuickSortRecursive(letters, startIndex, pivot - 1);
                }
                if (pivot + 1 < endIndex) {
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
