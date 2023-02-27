using DatingApp.Data.Fake;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Data
{
    public class DbInitializer
    {
        public DataContext Context { get; set; }


        public DbInitializer(DataContext? context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            Context = context;
        }

        public void InsertFakeData(int usersAmount)
        {
            if (usersAmount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(usersAmount), "Must not be negative.");
            }

            var userGenerator = new FakeUserGenerator();
            Context.Users.AddRange(userGenerator.GetAppUsers(usersAmount));

            Context.SaveChanges();
        }
    }
}
