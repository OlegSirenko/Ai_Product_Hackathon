#pragma once

#include "Measures.h";
#include <vector>

enum surface_type {
	undefined = 0,
	flooring = 1,
	wall = 2,
	ceiling = 3
};

/// <summary>
/// Image region where objects can be scaled correctly.
/// </summary>
class Region {
	std::vector<Point> corners;
public:
	surface_type surface{ undefined };

	/// <summary>
	/// Create Region.
	/// </summary>
	/// <param name="corners">Corners, that limit Region</param>
	Region(const std::vector<Point> &corners);

	/// <summary>
	/// Calculates approximate endpoint, keeping resulting vector parallel to direction.
	/// </summary>
	/// <param name="start"> </param>
	/// <param name="direction"></param>
	/// <returns></returns>
	virtual Point buildEndpoint_approximate(Point start, LineSegment direction) = 0;
	/// <summary>
	/// USE BUILDENDPOINT_APPROXIMATE INSTEAD!!!
	/// Calculates endpoint for planes with all measures.
	/// </summary>
	/// <param name="start"></param>
	/// <param name="direction"></param>
	/// <returns></returns>
	virtual Point buildEndpoint(Point start, LineSegment direction) = 0;

	/// <summary>
	/// returns four corners of convex quadrilateral, limiting this region.
	/// </summary>
	/// <returns></returns>
	std::vector<Point>* getCorners();
};