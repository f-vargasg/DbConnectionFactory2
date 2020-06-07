using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace DbConnFactory
{
    public sealed class DatabaseFactorySectionHandler  : ConfigurationSection
    {
        [ConfigurationProperty("", IsRequired = true, IsDefaultCollection = true)]
        public DbConfigInstanceCollection Instances 
        {
            get { return (DbConfigInstanceCollection)this[""]; }
            set { this[""] = value; }
        }
    }
    
}
