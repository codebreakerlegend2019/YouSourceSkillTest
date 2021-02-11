using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSourceSkillTest.Models
{
    public class SortResult
    {
        public string Result { get; set; }
        public bool IsSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public SortResult(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
        public SortResult()
        {
            IsSuccessful = true;
        }
    }
}
