using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCounter
{
    [Serializable]
    public class PropertyService
    {
        private static PropertyService instance = new PropertyService();

        private PropertyService() { }

        public static PropertyService getInstance()
        {
            return instance;
        }

        public static void setInstance(PropertyService inst)
        {
            instance = inst;
        }

        public int maxHistorie { get; set; }

        public System.Drawing.Size rectangleSize { get; set; }

        public float penWidth { get; set; }
    }
}
