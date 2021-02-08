using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Abstractions;

namespace HiXUnit.Mysql
{
    public class EFSqlTest
    {
        private ITestOutputHelper OutputHelper { get; }

        public EFSqlTest(ITestOutputHelper outputHelper)
        {
            OutputHelper = outputHelper;
        }

        [Fact]
        public void TestNativeQuery()
        {
            OutputHelper.WriteLine("this is xunit - MysqlTest");

            using (var context = new UserContext())
            {
                System.Linq.IQueryable<User> queryables = context.Users.FromSqlRaw("select * from users");
                System.Collections.Generic.List<User> users = queryables.ToListAsync().Result;
                OutputHelper.WriteLine("users=>{0}, ", users?.Count);

                foreach(var user in users)
                {
                    OutputHelper.WriteLine("user.id=>{0}, user.name=>{1}, ", user.Id, user.Name);
                }
                Assert.True(0 != 1);
            }
        }
    }
}
