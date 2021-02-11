using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YouSourceSkillTest.Controllers;
using YouSourceSkillTest.Enumerations;
using YouSourceSkillTest.Models;

namespace YourSourceSkillTest.UnitTest
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void BubbleSortTest()
        {
            var sortController = new SortController();
            var sortDto = new SortDto()
            {
                SortStrategy = SortStrategy.BUBBLESORT,
                TextToSort = "Lorem Ipsum"
            };
            Assert.AreEqual("ILemmoprsu",sortController.SortText(sortDto).Result);
        }
        [TestMethod]
        public void QuickSortTest()
        {
            var sortController = new SortController();
            var sortDto = new SortDto()
            {
                SortStrategy = SortStrategy.QUICKSORT,
                TextToSort = "simply"
            };
            Assert.AreEqual("ilmpsy", sortController.SortText(sortDto).Result);
        }
    }
}
