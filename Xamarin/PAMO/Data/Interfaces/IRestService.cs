using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PAMO
{
    public interface IRestService
    {
        
         Task<String> loginUser(string login, string password);

         Task<User> getUser(string token);

        Task<dynamic> getWeather(string queryString);

    }
}
