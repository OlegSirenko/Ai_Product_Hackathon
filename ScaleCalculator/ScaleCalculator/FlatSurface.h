#pragma once
#include "Region.h"

/// <summary>
/// Region without any vanishing points.
/// </summary>
class FlatSurface : public Region {
	LineSegment measure;
public:
	FlatSurface(const std::vector<Point>& corners, LineSegment measure);

	FlatSurface() = default;

	// Унаследовано через Region
	Point buildEndpoint_approximate(Point start, LineSegment direction) override;

	// Inherited via Region
	void Deserialize(const json& segment) override;
};