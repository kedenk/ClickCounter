using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickCounter
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            initProperties();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }

        /// <summary>
        /// Init the properties class
        /// </summary>
        static void initProperties()
        {
            if (!PropertiesLoader.loadProperties())
            {
                // apply std parameter
                PropertyService pService = PropertyService.getInstance();
                pService.maxHistorie = 5;

                pService.penWidth = 4.0F;
                pService.rectangleSize = new System.Drawing.Size(4, 4);
            }
        }
    }
}
