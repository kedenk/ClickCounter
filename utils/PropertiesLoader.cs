using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClickCounter
{
    class PropertiesLoader
    {
        private static string configName = "config.xml";


        /// <summary>
        /// Loads the properties from the config file, if it exists
        /// </summary>
        /// <returns></returns>
        public static Boolean loadProperties()
        {
            if( !File.Exists(configName) )
            {
                return false;
            }

            XmlSerializer serializer = getSerializer();
            using (var reader = XmlReader.Create(configName))
            {
                var instance = (PropertyService)serializer.Deserialize(reader);
                PropertyService.setInstance(instance);
                return true;
            }
        }

        /// <summary>
        /// Saves the properties to the config file
        /// </summary>
        public static void saveProperties()
        {
            XmlSerializer serializer = getSerializer();

            using (XmlWriter writer = XmlWriter.Create(configName))
            {

                serializer.Serialize(writer, PropertyService.getInstance());
            }
        }

        private static XmlSerializer getSerializer()
        {
            return new XmlSerializer((typeof(PropertyService)));
        }
    }
}
