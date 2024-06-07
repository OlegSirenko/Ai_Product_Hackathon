#pragma once
#include "Region.h"

/// <summary>
/// Region without any vanishing points.
/// </summary>
class FlatSurface :Region {
	LineSegment measure;
	FlatSurface(const std::vector<Point>& corners, LineSegment measure);

	// ������������ ����� Region
	virtual Point buildEndpoint_approximate(Point start, LineSegment direction) override;
	virtual Point buildEndpoint(Point start, LineSegment direction) override;
};