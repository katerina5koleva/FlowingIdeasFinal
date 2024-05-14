using Data.Model;
using Data;

namespace Business
{
	/// <summary>
	/// This class creates the controller, 
	/// in other words the business logic of the app. All of our main methods are here. 
	/// It's the connection between the data/base/ and the view.
	/// </summary>
	public class UserIdeaBusinessLogic
	{
		private UserIdeaContext ideaContext;

		/// <summary>
		/// This method checks if the username already exists in the database
		/// (in table Users)
		/// </summary>
		public bool CheckIfAccountExists(string writtenUsername)
		{
			using (ideaContext = new UserIdeaContext())
			{
				foreach (User user in ideaContext.Users)
				{
					if (user.Username.Contains(writtenUsername))
					{
						return true;
					}
				}

				return false;
			}
		}

		/// <summary>
		/// This method creates a user account in the DB.
		/// </summary>
		public void CreateAccount(string username)
		{
			using (ideaContext = new UserIdeaContext())
			{
				User user = new()
				{
					Username = username
				};

				ideaContext.Users.Add(user);
				ideaContext.SaveChanges();
			}
		}

		/// <summary>
		/// This method gets the user Id from the database
		/// based on the username.
		/// </summary>
		public int GetUserId(string username)
		{
			using (ideaContext = new UserIdeaContext())
			{
				foreach (User user in ideaContext.Users)
				{
					if (user.Username.Contains(username))
					{
						return user.Id;
					}
				}
			}

			throw new InvalidOperationException("User not found.");
		}
		/// <summary>
		/// This method converts the int IdeaTypeId to a string.
		/// </summary>
	
		public string GetIdeaTypeString(int ideaTypeId)
		{
			return ideaTypeId switch
			{
				1 => "Artistic",
				2 => "Philosophical",
				_ => "Work"
			};
		}

		/// <summary>
		/// This method creates the idea in the database.
		/// </summary>
		public void AddIdea(int userId, IdeaType ideaType, string ideaText)
		{
			using (ideaContext = new UserIdeaContext())
			{
				Idea idea = new()
				{
					UserId = userId,
					IdeaTypeId = ideaType,
					IdeaText = ideaText
				};

				ideaContext.Ideas.Add(idea);
				ideaContext.SaveChanges();
			}
		}

		/// <summary>
		/// This method gets all of the ideas of the signed up user.
		/// </summary>
		public List<Idea> GetAll(int userId)
		{
			using (ideaContext = new UserIdeaContext())
			{
				List<Idea> ideas = ideaContext.Ideas
					.Where(idea => idea.UserId == userId)
					.ToList();

				return ideas;
			}
		}

	/// <summary>
	/// This method gets the ideas of the user, depending on the type.
	/// </summary>

		public List<Idea> GetIdeasByType(int userId, IdeaType ideaType)
		{
			using (ideaContext = new UserIdeaContext())
			{
				List<Idea> filteredIdeas = ideaContext.Ideas
					.Where(idea => idea.UserId == userId && idea.IdeaTypeId == ideaType)
					.ToList();

				return filteredIdeas;
			}
		}

		/// <summary>
		/// This method deleted the chosen idea from the user ideas.
		/// </summary>
		public void Delete(int ideaId)
		{
			using (ideaContext = new UserIdeaContext())
			{
				Idea idea = ideaContext.Ideas.Find(ideaId);

				if (idea != null)
				{
					ideaContext.Ideas.Remove(idea);
					ideaContext.SaveChanges();
				}
			}
		}

		/// <summary>
		/// This method edits an already written idea by the user.
		/// </summary>
		public void Edit(int ideaId, int userId, string newTextOfIdea)
		{
			using (ideaContext = new UserIdeaContext())
			{
				Idea foundIdea = ideaContext.Ideas.FirstOrDefault(idea => idea.UserId == userId && idea.Id == ideaId);
				foundIdea.IdeaText = newTextOfIdea;
				ideaContext.SaveChanges();
			}
		}
	}
}
