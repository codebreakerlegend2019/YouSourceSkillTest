using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YouSourceSkillTest.Abstracts;
using YouSourceSkillTest.Enumerations;
using YouSourceSkillTest.Models;
using YouSourceSkillTest.SortStrategies;

namespace YouSourceSkillTest.Controllers
{
    public class SortController
    {
        #region Fields
        private SortStrategyBase _sortStrategy;
        #endregion
        #region Public Methods
        public SortResult SortText(SortDto sortDto)
        {
            if (IsTextContainsNumber(sortDto.TextToSort))
                return new SortResult("Text Contain Numbers!");
            if (string.IsNullOrEmpty(sortDto.TextToSort.ToString()))
                return new SortResult("Text To Sort Field Is Empty!");
            if (string.IsNullOrEmpty(sortDto.SortStrategy.ToString()))
                return new SortResult("No Sorting Strategy Selected!");
            if (!Regex.IsMatch(sortDto.TextToSort, @"^[a-zA-Z0-9\s.\?\,\'\;\:\!\-]+$"))
                return new SortResult("Special Character Not Allowed!");
            SetSortStrategy(sortDto.SortStrategy);
            return _sortStrategy.Sort(sortDto);
        }
        #endregion
        #region Private Methods
        private void SetSortStrategy(SortStrategy sortStrategy)
        {
            if (sortStrategy.Equals(SortStrategy.BUBBLESORT))
                _sortStrategy = new BubbleSort();
            else
                _sortStrategy = new QuickSort();
        }
        #endregion
        #region Validation Helper
        private bool IsTextContainsNumber(string text)
        {
            return text.ToList().Any(x => char.IsDigit(x));
        }
        #endregion


    }
}
