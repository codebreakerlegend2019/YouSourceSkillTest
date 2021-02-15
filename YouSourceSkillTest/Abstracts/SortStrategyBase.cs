using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouSourceSkillTest.Models;

namespace YouSourceSkillTest.Abstracts
{
    public abstract class SortStrategyBase
    {
        public abstract SortResult Sort(SortDto sortDto);
    }
}
