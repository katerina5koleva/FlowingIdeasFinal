using Data.Model;
using Data;
using System.Data.SqlClient;

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
                foreach (var item in ideaContext.Users)
                {
                    if (item.Username.Contains(writtenUsername))
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
                foreach (var user in ideaContext.Users)
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
        /// This method gets the ID of the idea type, needed in order to create an idea.
        /// </summary>
        public int IdeaType(int ideaTypeId)
        {
            return ideaTypeId;
        }
        /// <summary>
        /// This method converts the Id of the idea type to the name of the idea type.
        /// </summary>
        public string GetIdeaTypeString(int ideaTypeId)
        {
            if (ideaTypeId == 1)
            {
                return "Artistic";
            }
            else if (ideaTypeId == 2)
            {
                return "Philosophical";
            }
            else
            {
                return "Work";
            }
        }
        /// <summary>
        /// This method creates the idea in the database.
        /// </summary>
        public void AddIdea(int userId, int ideaType, string ideaText)
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
        /// This method gets all of the artistic ideas of the signed up user.
        /// </summary>
        public List<Idea> GetAllArtistic(int userId)
        {
            using (ideaContext = new UserIdeaContext())
            {
                List<Idea> artisticIdeas = ideaContext.Ideas
                                           .Where(idea => idea.UserId == userId)
                                           .Where(idea => idea.IdeaTypeId == 1)
                                           .ToList();
                return artisticIdeas;
            }
        }
        /// <summary>
        /// This method gets all of the philosophical ideas of the signed up user.
        /// </summary>
        public List<Idea> GetAllPhilosophical(int userId)
        {
            using (ideaContext = new UserIdeaContext())
            {
                List<Idea> philosophicalIdeas = ideaContext.Ideas
                                           .Where(idea => idea.UserId == userId)
                                           .Where(idea => idea.IdeaTypeId == 2)
                                           .ToList();
                return philosophicalIdeas;
            }
        }
        /// <summary>
        /// This method gets all of the work ideas of the signed up user.
        /// </summary>
        public List<Idea> GetAllWork(int userId)
        {
            using (ideaContext = new UserIdeaContext())
            {
                List<Idea> workIdeas = ideaContext.Ideas
                                           .Where(idea => idea.UserId == userId)
                                           .Where(idea => idea.IdeaTypeId == 3)
                                           .ToList();
                return workIdeas;
            }
        }
        /// <summary>
        /// This method deleted the chosen idea from the user ideas.
        /// </summary>
        public void Delete(int ideaId)
        {
            using (ideaContext = new UserIdeaContext())
            {
                var idea = ideaContext.Ideas.Find(ideaId);
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
                var idea = ideaContext.Ideas.FirstOrDefault(i => i.UserId == userId && i.Id == ideaId);
                idea.IdeaText = newTextOfIdea;
                ideaContext.SaveChanges();
            }
        }
    }
}
