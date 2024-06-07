#pragma once
#include "Region.h"

/// <summary>
/// !!!! Works correctly only with horizontal and vertical LineSegment !!!!
/// 
/// Region, having one vanishing point
/// </summary>
class SingleVanishingPoint_simplified : Region {
	LineSegment measure;
	Point vPoint;
	/// <summary>
	/// Create Region with Single Vanishing Point.
	/// </summary>
	/// <param name="corners">Corners, that limit Region</param>
	/// <param name="measure">!!!Only horizontal and vertical lines!!!  line on a plane, with known size.</param>
	/// <param name="vPoint">Vanishing point</param>
	SingleVanishingPoint_simplified(std::vector<Point> corners, LineSegment measure, Point vPoint);

	// Унаследовано через Region
	virtual Point buildEndpoint_approximate(Point start, LineSegment direction) override;
	virtual Point buildEndpoint(Point start, LineSegment direction) override;
};