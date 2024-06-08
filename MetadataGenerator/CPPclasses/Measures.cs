using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CPPclasses
{
    /// <summary>
    /// Coordinates of a point.
    /// </summary>
    public class Point
    {
        public double x { get; set; } = 0;
        public double y { get; set; } = 0;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
        }
    }
    /// <summary>
    /// Represents line equation in a form "y = ax + b".
    /// </summary>
    public class Line
    {
        public double a { get; set; } = 0;
        public double b { get; set; } = 0;
        public Line(Point first, Point second)
        {
            //костыль чтобы работало с вертикальными прямыми, нужно убрать
            if (first.x == second.x)
            {
                second.x += 0.001;
            }
            if (first.y == second.y)
            {
                second.y += 0.001;
            }
            this.a = (second.y - first.y) / (second.x - first.x);
            this.b = (second.x * first.y - first.x * second.y) / (second.x - first.x);
        }
        public Line(LineSegment segment) : this(segment.end, segment.start) { }

        public Line() { }
    };

    /// <summary>
    /// Represents measured line segment in the allowed region of the Image.
    /// </summary>
    public class LineSegment
    {
        public Point start { get; set; } = new Point();
        public Point end { get; set; } = new Point();
        public double length { get; set; } = 0;

        public LineSegment() { }

        public LineSegment(Point start, Point end, double length)
        {
            this.start = start;
            this.end = end;
            this.length = length;
        }

        public double GetPixelLength()
        {
            return Math.Sqrt(Math.Pow(end.x - start.x, 2) + Math.Pow(end.y - start.y, 2));
        }
        public Point GetUnitVectorEnd()
        {
            Point unitVectorEnd = new();
            unitVectorEnd.x = (end.x - start.x) / GetPixelLength();
            unitVectorEnd.y = (end.y - start.y) / GetPixelLength();
            return unitVectorEnd;
        }
        public LineSegment BuildCroppedSegmentFromPoint(Point start, double pixelLength)
        {
            Point vectorEnd = GetUnitVectorEnd();
            vectorEnd.x *= pixelLength;
            vectorEnd.y *= pixelLength;

            vectorEnd.x += start.x;
            vectorEnd.y += start.y;
            LineSegment segment = new(start, vectorEnd, length);
            return segment;
        }
    };

    public class Measures
    {
        public static Line BuildPerpendicular(Line line, Point point)
        {
            Line perpendicular = new();
            perpendicular.a = -1 / line.a;
            perpendicular.b = (point.x / line.a + point.y);
            return perpendicular;
        }

        public static Point CalculateIntersection(Line first, Line second)
        {
            Point intersection = new();
            intersection.x = (first.b - second.b) / (second.a - first.a);
            intersection.y = first.a * intersection.x + first.b;
            return intersection;
        }

        public static double CalculateDistance(Point start, Point end)
        {
            return Math.Sqrt(Math.Pow(end.x - start.x, 2) + Math.Pow(end.y - start.y, 2));
        }
    }
}
