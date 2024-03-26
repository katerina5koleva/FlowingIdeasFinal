using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{/// <summary>
 /// This class is the structure of the table "Idea" in the database. 
 /// It has an auto incremented id, 
 /// a two foreign keys: UserId that references table "Users" 
 /// and IdeaTypeId, referencing table "IdeaType". 
 /// It also has the property IdeaText that saves the text of the idea. 
 /// </summary>
    public class Idea
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int IdeaTypeId { get; set; }
        public string IdeaText { get; set; }

    }

}
