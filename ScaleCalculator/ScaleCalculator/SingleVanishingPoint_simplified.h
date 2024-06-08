#pragma once
#include "Region.h"

/// <summary>
/// !!!! Works correctly only with horizontal and vertical LineSegment !!!!
/// 
/// Region, having one vanishing point
/// </summary>
class SingleVanishingPoint_simplified : public Region {
	LineSegment measure;
	Point vPoint;
public:
	/// <summary>
	/// Create Region with Single Vanishing Point.
	/// </summary>
	/// <param name="corners">Corners, that limit Region</param>
	/// <param name="measure">!!!Only horizontal and vertical lines!!!  line on a plane, with known size.</param>
	/// <param name="vPoint">Vanishing point</param>
	SingleVanishingPoint_simplified(std::vector<Point> corners, LineSegment measure, Point vPoint);

	SingleVanishingPoint_simplified() = default;

	// Унаследовано через Region
	Point buildEndpoint_approximate(Point start, LineSegment direction) override;
	Point buildEndpoint(Point start, LineSegment direction) override;
};