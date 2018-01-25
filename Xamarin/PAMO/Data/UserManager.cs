using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
//using PCLStorage;

namespace PAMO
{
    public class UserManager
    {
        IRestService restService;
        IStorageService storageService;
        User user;

        public UserManager(IRestService service, IStorageService storage)
        {
            restService = service;
            storageService = storage;
        }

        public async Task<String> isLogin(string login, string password)
        {
            String token = await restService.loginUser(login, password);
            if (!token.Equals(""))
            {
                return token;
            }
            else
            {       
                return "";
            }
           
        }

        public async Task<User> getUserState(string token)
        {
            user = await restService.getUser(token);
            return this.user;
        }

        public async Task saveToken(string token)
        {
            await storageService.Clean("token.txt");
            await storageService.Write("token.txt", token);
        }

        public async Task<String> getToken()
        {
            return await storageService.Read("token.txt");
        }

        public async Task Logout()
        {
           await storageService.Clean("token.txt");
        }
    }
}
