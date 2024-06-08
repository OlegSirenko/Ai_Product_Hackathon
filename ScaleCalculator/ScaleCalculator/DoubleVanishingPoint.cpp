#include "DoubleVanishingPoint.h"
#include <cmath>

double CalculateCoefficient(LineSegment measure, Point vPoint) {
	double dist1 = CalculateDistance(vPoint, measure.start);
	double dist2 = CalculateDistance(vPoint, measure.end);
	return (dist1 * dist2 * measure.length) / abs(dist1 - dist2);
}

DoubleVanishingPoint::DoubleVanishingPoint(std::vector<Point> corners, LineSegment measure_one, Point vPoint_one, LineSegment measure_two, Point vPoint_two):Region(corners)
{
	this->vPoint_one = vPoint_one;
	this->vPoint_two = vPoint_two;

	this->measure_one = measure_one;
	this->measure_two = BuildPerpendicular();

	coefficient_one = CalculateCoefficient(measure_one, vPoint_one);
	coefficient_two = CalculateCoefficient(measure_two, vPoint_two);
}

Point DoubleVanishingPoint::buildEndpoint_approximate(Point start, LineSegment direction)
{
	return direction.BuildCroppedSegmentFromPoint(start, CalculateDistance(start, buildEndpoint(start, direction))).end;
}

Point BuildMeasuredProjection(Point start, LineSegment direction, Point vPoint, double coefficient, LineSegment measure, Point vPointOrtagonal) {
	LineSegment directionProjection(
		CalculateIntersection(Line(direction.start, vPointOrtagonal), Line(measure)),
		CalculateIntersection(Line(direction.end, vPointOrtagonal), Line(measure)), 0);
	double projectionRatio = directionProjection.GetPixelLength() / direction.GetPixelLength();
	directionProjection.length = direction.length * projectionRatio;

	direction = direction.BuildCroppedSegmentFromPoint(start, 1);

	auto distanceToStartpoint = CalculateDistance(vPoint, directionProjection.start);
	auto distanceToEndpoint = coefficient / (directionProjection.length + coefficient / CalculateDistance(vPoint, directionProjection.start));
	return directionProjection.BuildCroppedSegmentFromPoint(directionProjection.start, distanceToEndpoint - distanceToStartpoint).end;
}

Point DoubleVanishingPoint::buildEndpoint(Point start, LineSegment direction)
{	
	auto endpoint1 = BuildMeasuredProjection(start, direction, vPoint_one, coefficient_one, measure_one, vPoint_two);
	auto endpoint2 = BuildMeasuredProjection(start, direction, vPoint_two, coefficient_two, measure_two, vPoint_one);

	auto result = CalculateIntersection(Line(endpoint1, vPoint_two), Line(endpoint2, vPoint_one));
	return result;
}
