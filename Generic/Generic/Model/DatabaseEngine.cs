using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Model
{
    internal class DatabaseEngine
    {
        private string password;
        public DatabaseValue<T> WriteValue<T>(T value, string password)
        {
            DatabaseValue<T> dbValue = new DatabaseValue<T>();
            dbValue.value = value;
            this.password = password;
            return dbValue;
            
        }
        public class DatabaseValue<T>
        {
            public T value { get; set; }
            public string tableName { get; }
               
            
        }
    }
}
