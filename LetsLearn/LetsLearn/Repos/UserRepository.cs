using System.Runtime.InteropServices.ComTypes;
using LetsLearn.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace LetsLearn.Repos
{
    public class UserRepository : Repository
    {
        ManagementContext _context;
        public UserRepository(ManagementContext userContext) : base(userContext)
        {
            _context = userContext;
        }

        public async Task<ICollection<User>> GetStudentsByClass(string clasa)
        {
            return await _context.Set<User>().Where(s => s.Clasa.Equals(clasa)).ToListAsync();
        }

    }
}
