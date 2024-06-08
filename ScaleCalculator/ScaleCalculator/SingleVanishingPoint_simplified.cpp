#include "SingleVanishingPoint_simplified.h"

SingleVanishingPoint_simplified::SingleVanishingPoint_simplified(std::vector<Point> corners, LineSegment measure, Point vPoint):Region(corners)
{
	this->measure = measure;
	this->vPoint = vPoint;
}

Point SingleVanishingPoint_simplified::buildEndpoint_approximate(Point start, LineSegment direction)
{
	LineSegment directionProjection(
		CalculateIntersection(BuildPerpendicular(Line(measure), direction.start), Line(measure)),
		CalculateIntersection(BuildPerpendicular(Line(measure), direction.end), Line(measure)), 0);
	double projectionRatio = directionProjection.GetPixelLength() / direction.GetPixelLength();
	directionProjection.length = direction.length * projectionRatio;

	double pixelLength = (directionProjection.length * (measure.GetPixelLength() / measure.length))/ projectionRatio;

	LineSegment measuredSegment = direction.BuildCroppedSegmentFromPoint(CalculateIntersection(Line(measure),Line(vPoint, start)), pixelLength);

	Line dirLine(direction.BuildCroppedSegmentFromPoint(start, pixelLength));

	return CalculateIntersection(dirLine, Line(measuredSegment.end, vPoint));
}

void SingleVanishingPoint_simplified::Deserialize(const json& segment)
{
	this->measure.Deserialize(segment["measure"]);
	this->vPoint.Deserialize(segment["vPoint"]);
}
