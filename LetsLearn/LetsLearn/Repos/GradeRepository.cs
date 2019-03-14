using LetsLearn.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.Repos
{
    public class GradeRepository : Repository
    {
        public GradeRepository(ManagementContext teacherContext) : base(teacherContext)
        {
        }
    }
}
