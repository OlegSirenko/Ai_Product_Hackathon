using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPPclasses;

namespace MetadataGenerator
{
    public abstract class TableItem
    {
        public List<Point> corners = new List<Point>() { new Point(), new Point(), new Point(), new Point() };
        public surface_type surface = surface_type.undefined;

        protected static List<Point> getVector()
        {
            return new List<Point>() { new Point(), new Point() };
        }
    }

    public class TableItemFlat : TableItem
    {
        public List<Point> measure = getVector();
        public double length = 0;
    }
    public class TableItemSingle : TableItem
    {
        public List<Point> parallel1 = getVector();
        public List<Point> parallel2 = getVector();
        public List<Point> measure = getVector();
        public double length = 0;
    }
    class TableItemDouble : TableItem
    {
        public List<Point> measure_one = getVector();
        public double length_one = 0;
        public List<Point> parallel_one = getVector();
        public List<Point> measure_two = getVector();
        public double length_two = 0;
        public List<Point> parallel_two = getVector();
    }
}
