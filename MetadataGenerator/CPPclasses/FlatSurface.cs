using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPclasses
{
    public class FlatSurface : Region
    {
        public LineSegment measure { get; set; }
        public FlatSurface(List<Point> corners, LineSegment measure) : base(corners)
        {
            this.measure = measure;
        }

        public FlatSurface() { }

        // Унаследовано через Region
        public override Point buildEndpoint_approximate(Point start, LineSegment direction)
        {
            double length = direction.length * (measure.GetPixelLength() / measure.length);
            return direction.BuildCroppedSegmentFromPoint(start, length).end;
        }
    };
}
