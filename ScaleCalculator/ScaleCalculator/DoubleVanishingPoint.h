#pragma once
#include "Region.h"

/// <summary>
/// Region, having two vanishing points
/// </summary>
class DoubleVanishingPoint: public Region {
private:
	double coefficient_one, coefficient_two;
	LineSegment measure_one, measure_two;
	Point vPoint_one, vPoint_two;
	double CalculateSegmentLength(Point start, Point end);
public:
	DoubleVanishingPoint(std::vector<Point> corners, LineSegment measure_one, Point vPoint_one, LineSegment measure_two, Point vPoint_two);
	DoubleVanishingPoint() = default;

	// Inherited via Region
	Point buildEndpoint_approximate(Point start, LineSegment direction) override;
	Point buildEndpoint(Point start, LineSegment direction) override;
};