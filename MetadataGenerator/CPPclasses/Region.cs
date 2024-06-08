using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPclasses
{
    public enum surface_type
    {
        undefined = 0,
        flooring = 1,
        wall = 2,
        ceiling = 3
    };

    /// <summary>
    /// Image region where objects can be scaled correctly.
    /// </summary>
    public abstract class Region
    {
        public List<Point> corners { get; set; }
        public surface_type surface { get; set; } = surface_type.undefined;

        /// <summary>
        /// Create Region.
        /// </summary>
        /// <param name="corners">Corners, that limit Region</param>
        public Region(List<Point> corners)
        {
            this.corners = corners;
        }

        public Region()
        {
            this.corners = new List<Point>();
        }

        /// <summary>
        /// Calculates approximate endpoint, keeping resulting vector parallel to direction.
        /// </summary>
        /// <param name="start"> </param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public abstract Point buildEndpoint_approximate(Point start, LineSegment direction);

        /// <summary>
        /// returns four corners of convex quadrilateral, limiting this region.
        /// </summary>
        /// <returns></returns>
        public List<Point> getCorners()
        {
            return this.corners;
        }
    };
}
