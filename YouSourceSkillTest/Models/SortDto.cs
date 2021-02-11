using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouSourceSkillTest.Enumerations;

namespace YouSourceSkillTest.Models
{
    public class SortDto
    {
        public string TextToSort { get; set; }
        public SortStrategy SortStrategy { get; set; }
    }
}
