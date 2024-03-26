using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    ///<summary>
    ///This class is the structure of the table "IdeaType" in the database. 
    ///It maps an auto incremented id and the type of the idea.
    ///</summary>

    public class IdeaType
    {
        public int Id { get; set; }
        public string IdeaTypeName{ get; set; }
    }
}
