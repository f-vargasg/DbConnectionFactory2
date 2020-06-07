using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace DbConnFactory
{
    class DbConfigInstanceElement: ConfigurationElement
    {
        //Make sure to set IsKey=true for property exposed as the GetElementKey above
        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get { return (string)base["name"]; }
        }


        [ConfigurationProperty("ConnectionStringName")]
        public string ConnectionStringName
        {
            get { return (string)base["ConnectionStringName"]; }
        }

        public string ConnectionString
        {
            get
            {
                try
                {
                    return ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
                }
                catch (Exception excep)
                {
                    throw new Exception("Connection string " + ConnectionStringName + " was not found in web.config. " + excep.Message);
                }
            }
        }

        [ConfigurationProperty("id")]
        public int Id
        {
            get { return Convert.ToInt32( this["id"]); }
        }
        
    
    }
}
