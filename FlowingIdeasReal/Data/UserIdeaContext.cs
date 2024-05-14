using System.Data.Entity;
using Data.Model;

namespace Data
{
	/// <summary>
	/// This class maps the classes 
	/// we have in the folder "Model" into the tables of the database.
	/// </summary>
	public class UserIdeaContext : DbContext
	{
		// reference to the name of the connection string
		public UserIdeaContext() : base("name=UserIdeaContext")
		{ }

		public DbSet<User> Users { get; set; }

		public DbSet<Idea> Ideas { get; set; }
	}
}
