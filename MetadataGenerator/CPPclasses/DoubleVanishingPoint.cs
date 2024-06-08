using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPclasses
{
    public class DoubleVanishingPoint : Region
    {
        public double coefficient_one { get; set; }
        public double coefficient_two { get; set; }
        public LineSegment measure_one { get; set; }
        public LineSegment measure_two { get; set; }
        public Point vPoint_one { get; set; }
        public Point vPoint_two { get; set; }
        private double CalculateCoefficient(LineSegment measure, Point vPoint)
        {
            double dist1 = Measures.CalculateDistance(vPoint, measure.start);
            double dist2 = Measures.CalculateDistance(vPoint, measure.end);
            return (dist1 * dist2 * measure.length) / Math.Abs(dist1 - dist2);
        }

        private double CalculateProjectionLength(Point start, Point end, Line measure, double coefficient, Point vPoint, Point ortagonalVPoint)
        {
            start = Measures.CalculateIntersection(measure, new Line(start, ortagonalVPoint));
            end = Measures.CalculateIntersection(measure, new Line(end, ortagonalVPoint));

            var startDist = Measures.CalculateDistance(start, vPoint);
            var endDist = Measures.CalculateDistance(end, vPoint);

            return coefficient / startDist - coefficient / endDist;
        }

        private double CalculateSegmentLength(Point start, Point end)
        {
            return Math.Sqrt(Math.Pow(CalculateProjectionLength(start, end, new Line(measure_one), coefficient_one, vPoint_one, vPoint_two), 2)
                      + Math.Pow(CalculateProjectionLength(start, end, new Line(measure_two), coefficient_two, vPoint_two, vPoint_one), 2));
        }
        public DoubleVanishingPoint(List<Point> corners, LineSegment measure_one, Point vPoint_one, LineSegment measure_two, Point vPoint_two) : base(corners)
        {
            this.vPoint_one = vPoint_one;
            this.vPoint_two = vPoint_two;

            this.measure_one = measure_one;
            this.measure_two = measure_two;

            coefficient_one = CalculateCoefficient(measure_one, vPoint_one);
            coefficient_two = CalculateCoefficient(measure_two, vPoint_two);
        }
        public DoubleVanishingPoint() { }

        public override Point buildEndpoint_approximate(Point start, LineSegment direction)
        {
            //i'm tired, binary search will work for now....
            var horizontPoint = Measures.CalculateIntersection(new Line(direction.BuildCroppedSegmentFromPoint(start, 1)), new Line(vPoint_one, vPoint_two));
            direction = direction.BuildCroppedSegmentFromPoint(start, Measures.CalculateDistance(start, horizontPoint));

            Point binaryStart = direction.start, binaryEnd = direction.end;

            while (true)
            {
                Point binaryCenter = new((binaryEnd.x + binaryStart.x) / 2, (binaryEnd.y + binaryStart.y) / 2);
                var currentLength = CalculateSegmentLength(start, binaryCenter);
                if (Math.Abs(direction.length - currentLength) < 0.03 * direction.length || Measures.CalculateDistance(binaryStart, binaryEnd) < 1)
                {
                    return binaryCenter;
                }
                if (currentLength > direction.length)
                {
                    binaryEnd = binaryCenter;
                }
                else
                {
                    binaryStart = binaryCenter;
                }
            }
        }
    };
}
