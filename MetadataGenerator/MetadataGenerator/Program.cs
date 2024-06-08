using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPPclasses;
using System.Text.Json;
using System.IO;

namespace MetadataGenerator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DoubleVanishingPoint dp = new (new List<Point>(), new LineSegment(new Point(500, 1055), new Point(1115, 1015), 280), new Point(5144, 766), new LineSegment(new Point(1816, 1135), new Point(2172, 1226), 70), new Point(365, 770));
            var d = dp.buildEndpoint_approximate(new Point(100, 1500), new LineSegment(new Point(0, 10), new Point(0, 0), 100));

            RegionList regionList = new RegionList();
            regionList.DoubleVanishingPoints.Add(dp);
            regionList.SerializeThis();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
