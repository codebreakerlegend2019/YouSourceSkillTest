using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouSourceSkillTest.Controllers;
using YouSourceSkillTest.Enumerations;
using YouSourceSkillTest.Models;

namespace YourSourceSkillTest.UnitTest
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        public void NoNumberAllowedTest()
        {
            var sortController = new SortController();
            var sortDto = new SortDto()
            {
                SortStrategy = SortStrategy.BUBBLESORT,
                TextToSort = "Lorem Ipsum123"
            };
            Assert.IsFalse(sortController.SortText(sortDto).IsSuccessful);
        }
        [TestMethod]
        public void InvalidOrNoSortStrategyTest()
        {
            var sortController = new SortController();
            var sortDto = new SortDto()
            {
                TextToSort = "Lorem Ipsum"
            };
            // It should be True because not setting Sort Strategy will have default BUBBLE SORT
            Assert.IsTrue(sortController.SortText(sortDto).IsSuccessful);
        }
        [TestMethod]
        public void NoSpecialCharacterTest()
        {
            var sortController = new SortController();
            var sortDto = new SortDto()
            {
                TextToSort = "Lorem Ipsu@@"
            };
            Assert.IsFalse(sortController.SortText(sortDto).IsSuccessful);
        }
    }
}
