using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPclasses
{
    public class SingleVanishingPoint_simplified : Region
    {
        public LineSegment measure { get; set; }
        public Point vPoint { get; set; }
        /// <summary>
        /// Create Region with Single Vanishing Point.
        /// </summary>
        /// <param name="corners">Corners, that limit Region</param>
        /// <param name="measure">!!!Only horizontal and vertical lines!!!  line on a plane, with known size.</param>
        /// <param name="vPoint">Vanishing point</param>
        public SingleVanishingPoint_simplified(List<Point> corners, LineSegment measure, Point vPoint) : base(corners)
        {
            this.measure = measure;
            this.vPoint = vPoint;
        }
        public SingleVanishingPoint_simplified() { }

        // Унаследовано через Region
        public override Point buildEndpoint_approximate(Point start, LineSegment direction)
        {
            LineSegment directionProjection = new(
                                                    Measures.CalculateIntersection(Measures.BuildPerpendicular(new Line(measure), direction.start), new Line(measure)),
                                                    Measures.CalculateIntersection(Measures.BuildPerpendicular(new Line(measure), direction.end), new Line(measure)), 0);
            double projectionRatio = directionProjection.GetPixelLength() / direction.GetPixelLength();
            directionProjection.length = direction.length * projectionRatio;

            double pixelLength = (directionProjection.length * (measure.GetPixelLength() / measure.length)) / projectionRatio;

            LineSegment measuredSegment = direction.BuildCroppedSegmentFromPoint(Measures.CalculateIntersection(new Line(measure), new Line(vPoint, start)), pixelLength);

            Line dirLine = new(direction.BuildCroppedSegmentFromPoint(start, pixelLength));

            return Measures.CalculateIntersection(dirLine, new Line(measuredSegment.end, vPoint));
        }
    }
}
