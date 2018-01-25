using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PAMO
{
    [Table("City")]
    public class City
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public string city_name { get; set; }

        public string ZipCode { get; set; }

        public City()
        {

        }

        public City(string name, string ZipCode)
        {
            this.city_name = name;
            this.ZipCode = ZipCode;
        }

        public override string ToString()
        {
            return city_name;
        }
    }
}
