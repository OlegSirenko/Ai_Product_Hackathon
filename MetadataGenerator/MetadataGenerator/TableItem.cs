using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPPclasses;

namespace MetadataGenerator
{
    public class TableItem
    {
        public int amount = 0;
        public List<Point> corners = new List<Point>() { new Point(), new Point(), new Point(), new Point() };
        public surface_type surface = surface_type.undefined;
        public List<Point> singleParallel1 = getVector();
        public List<Point> singleParallel2 = getVector();
        public List<Point> measure = getVector();
        public double length = 0;

        public List<Point> measure_one = getVector();
        public double length_one = 0;
        public List<Point> parallel_one = getVector();
        public List<Point> measure_two = getVector();
        public double length_two = 0;
        public List<Point> parallel_two = getVector();

        protected static List<Point> getVector()
        {
            return new List<Point>() { new Point(), new Point() };
        }
    }
}
