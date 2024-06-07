#pragma once
#include "Region.h"

/// <summary>
/// Region without any vanishing points.
/// </summary>
class FlatSurface : public Region {
	LineSegment measure;
public:
	FlatSurface(const std::vector<Point>& corners, LineSegment measure);

	// Унаследовано через Region
	virtual Point buildEndpoint_approximate(Point start, LineSegment direction) override;
	virtual Point buildEndpoint(Point start, LineSegment direction) override;
};