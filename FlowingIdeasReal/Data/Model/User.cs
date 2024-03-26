using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    /// <summary>
     /// This class is the structure of the table "Users" in the database. 
     /// It has an auto incremented id and a username.
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

    }

}

