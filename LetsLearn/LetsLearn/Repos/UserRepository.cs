using LetsLearn.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LetsLearn.Repos
{
    public class UserRepository : Repository
    {
        public UserRepository(ManagementContext userContext) : base(userContext)
        {
           
        }

       
    }
}
