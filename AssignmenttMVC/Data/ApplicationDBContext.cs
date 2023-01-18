
using Microsoft.EntityFrameworkCore;
using AssignmenttMVC.Models;


namespace AssignmenttMVC.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<EventsModel> Event { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<RegisterUserModel> Register { get; set; }
        public DbSet<CommentModel> Comment { get; set; }

    }
}
