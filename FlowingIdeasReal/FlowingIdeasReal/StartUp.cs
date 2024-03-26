using FlowingIdeas.Presentation;

namespace FlowingIdeasReal
{
    public static class StartUp
    {
        /// <summary>
        ///  This is an app in which you can write and save your ideas 
        ///  in the following categories: artistic, work, philosophical.
        ///  It uses the entity framework and Microsoft SQL Server.
        ///  It requiers a username.
       /// </summary>
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new IdeasFlow());
        }
    }
}