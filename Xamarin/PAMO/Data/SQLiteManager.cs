using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;
using System.Linq;
using System.IO;

namespace PAMO
{
    public class SQLiteManager
    {
        private SQLiteConnection connection;

        public SQLiteManager()
        {
            try
            {
                var fileName = "MyDataBase.db3";
                var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                var path = Path.Combine(documentsPath, fileName);

                connection = new SQLiteConnection(path);
                connection.CreateTable<City>();
                connection.CreateTable<User>();
            }
            catch (NullReferenceException)
            {

            }
        }

        public List<City> GetCities()
        {
            try { 
            return (from t in connection.Table<City>()
                    select t).ToList();
            }catch(Exception npe)
            {
                System.Diagnostics.Debug.WriteLine(npe);
                return null;
            }
        }

        public City GetCity(int id)
        {
            return connection.Table<City>().FirstOrDefault(t => t.id == id);
        }

        public void AddCity(City city)
        {
            var newCity = city;
            connection.Insert(newCity);
        }

        public User GetUser(int id)
        {
            return connection.Table<User>().FirstOrDefault(t => t.id == id);
        }

        public void AddUser(User user)
        {
            var newUSer = user;
            connection.InsertOrReplace(newUSer);
        }
    }
}
