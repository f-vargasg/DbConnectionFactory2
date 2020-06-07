using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DbConnFactory
{
    public sealed class DatabaseFactory
    {
        public static DatabaseFactorySectionHandler sectionHandler;

        private DatabaseFactory() { }
        public static Database CreateDatabase(int pId)
        {
            Database res = null;
            bool found = false;
            try
            {
                var sectionHandler = ConfigurationManager.GetSection("DatabaseFactoryConfiguration")
                                 as DatabaseFactorySectionHandler;
                IEnumerator wen = sectionHandler.Instances.GetEnumerator();
                while (wen.MoveNext() && !found)
                {
                    DbConfigInstanceElement item = (DbConfigInstanceElement)(wen.Current);
                    if (item.Id == pId )
                    {
                        Console.WriteLine("Encontrado !!! " + Convert.ToString ( item.Id));
                        found = true;
                        // Verify a DatabaseFactoryConfiguration line exists in the web.config.
                        /* if (item.Name.Length <= 0)
                        {
                            throw new Exception("Database name not defined in DatabaseFactoryConfiguration section of web.config.");
                        }*/
                        try
                        {
                            // Find the class
                            Type database = Type.GetType(item.Name);
                            // Get it's constructor
                            ConstructorInfo constructor = database.GetConstructor(new Type[] { });
                            // Invoke it's constructor, which returns an instance.
                            Database createdObject = (Database)constructor.Invoke(null);
                            // Initialize the connection string property for the database.
                            createdObject.connectionString = item.ConnectionString;
                            // Pass back the instance as a Database
                            res = createdObject;
                            // return createdObject;
                        }
                        catch (Exception excep)
                        {
                            throw new Exception("Error instantiating database " + item.Name + ". " + excep.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return res;
        }
    }
}
