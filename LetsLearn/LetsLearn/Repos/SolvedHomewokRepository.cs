using LetsLearn.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.Repos
{
    public class SolvedHomeworkRepository : Repository
    {
        public SolvedHomeworkRepository(ManagementContext teacherContext) : base(teacherContext)
        {

        }
    }

}
