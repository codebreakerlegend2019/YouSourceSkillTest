using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouSourceSkillTest.Abstracts;
using YouSourceSkillTest.Models;

namespace YouSourceSkillTest.SortStrategies
{
    public class BubbleSort : SortStrategyBase
    {
        public override SortResult Sort(SortDto sortDto)
        {
            return new SortResult()
            {
                Result = DoBubbleSort(sortDto.TextToSort)
            };
        }
        #region Private Methods
        private string DoBubbleSort(string word)
        {
            var letters = word.Where(x => !x.Equals(' ')).ToList();
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

            return string.Join("", letters);
        }
        #endregion
    }
}
