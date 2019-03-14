using LetsLearn.Data;


namespace LetsLearn.Repos
{
    public class UserRepository : Repository
    {
        public UserRepository(ManagementContext userContext) : base(userContext)
        {
        }
    }
}
