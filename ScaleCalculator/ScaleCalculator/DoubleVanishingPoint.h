#pragma once
#include "Region.h"

/// <summary>
/// Region, having two vanishing points
/// </summary>
class DoubleVanishingPoint {
	LineSegment measure_one, measure_two;
	Point vPoint_one, vPoint_two;
	DoubleVanishingPoint(std::vector<Point> corners, LineSegment measure_one, Point vPoint_one, LineSegment measure_two, Point vPoint_two);
};