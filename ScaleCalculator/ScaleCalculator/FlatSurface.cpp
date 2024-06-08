#include "FlatSurface.h"

FlatSurface::FlatSurface(const std::vector<Point>& corners, LineSegment measure):Region(corners)
{
	this->measure = measure;
}

Point FlatSurface::buildEndpoint_approximate(Point start, LineSegment direction)
{
	double length = direction.length * (measure.GetPixelLength() / measure.length);
	return direction.BuildCroppedSegmentFromPoint(start, length).end;
}

void FlatSurface::Deserialize(const json& segment)
{
	this->measure.Deserialize(segment["measure"]);
}
