using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace DbConnFactory
{
    public class DbConfigInstanceCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new DbConfigInstanceElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            //set to whatever Element Property you want to use for a key
            return ((DbConfigInstanceElement)element).Name;
        }
    }
}
