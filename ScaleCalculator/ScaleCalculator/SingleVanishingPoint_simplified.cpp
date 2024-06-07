#include "SingleVanishingPoint_simplified.h"

SingleVanishingPoint_simplified::SingleVanishingPoint_simplified(std::vector<Point> corners, LineSegment measure, Point vPoint):Region(corners)
{
	this->measure = measure;
	this->vPoint = vPoint;
}

Point SingleVanishingPoint_simplified::buildEndpoint_approximate(Point start, LineSegment direction)
{
	LineSegment dirProjection(
		CalculateIntersection(BuildPerpendicular(Line(measure), direction.start), Line(measure)),
		CalculateIntersection(BuildPerpendicular(Line(measure), direction.end), Line(measure)), 0);
	auto tmp = dirProjection.GetPixelLength();
	tmp = direction.GetPixelLength();
	double projectionRatio = dirProjection.GetPixelLength() / direction.GetPixelLength();
	dirProjection.length = direction.length * projectionRatio;

	double pixelLength = (dirProjection.length * (measure.GetPixelLength() / measure.length))/ projectionRatio;

	LineSegment measuredSegment = direction.BuildCroppedSegmentFromPoint(CalculateIntersection(Line(measure),Line(vPoint, start)), pixelLength);

	Line dirLine(direction.BuildCroppedSegmentFromPoint(start, pixelLength));

	return CalculateIntersection(dirLine, Line(measuredSegment.end, vPoint));
}

Point SingleVanishingPoint_simplified::buildEndpoint(Point start, LineSegment direction)
{
	throw "Not Implemented";
}
