using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using SQLite;


namespace PAMO
{
    [Table("City")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string token { get; set; }
        public string section_id { get; set; }

        public User()
        {

        }

        public User(string username, string token)
        {
            this.username = username;
            this.token = token;

        }
    }

    

}
