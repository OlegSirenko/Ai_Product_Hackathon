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
	this->measure_two = measure_two;

	coefficient_one = CalculateCoefficient(measure_one, vPoint_one);
	coefficient_two = CalculateCoefficient(measure_two, vPoint_two);
}

double CalculateProjectionLength(Point start, Point end, Line measure, double coefficient, Point vPoint, Point ortagonalVPoint) {
	start = CalculateIntersection(measure, Line(start, ortagonalVPoint));
	end = CalculateIntersection(measure, Line(end, ortagonalVPoint));

	auto startDist = CalculateDistance(start, vPoint);
	auto endDist = CalculateDistance(end, vPoint);

	return coefficient / startDist - coefficient / endDist;
}

double DoubleVanishingPoint::CalculateSegmentLength(Point start, Point end) {
	return sqrt(pow(CalculateProjectionLength(start, end, Line(measure_one), coefficient_one, vPoint_one, vPoint_two), 2)
		      + pow(CalculateProjectionLength(start, end, Line(measure_two), coefficient_two, vPoint_two, vPoint_one), 2));
}

Point DoubleVanishingPoint::buildEndpoint_approximate(Point start, LineSegment direction)
{
	//i'm tired, binary search will work for now....
	auto horizontPoint = CalculateIntersection(Line(direction.BuildCroppedSegmentFromPoint(start, 1)), Line(vPoint_one, vPoint_two));
	direction = direction.BuildCroppedSegmentFromPoint(start, CalculateDistance(start, horizontPoint));

	Point binaryStart = direction.start, binaryEnd = direction.end;
	
	while (true) {
		Point binaryCenter((binaryEnd.x + binaryStart.x)/2, (binaryEnd.y + binaryStart.y)/2);
		auto currentLength = CalculateSegmentLength(start, binaryCenter);
		if (abs(direction.length - currentLength) < 0.03 * direction.length || CalculateDistance(binaryStart, binaryEnd) < 1) {
			return binaryCenter;
		}
		if (currentLength > direction.length) {
			binaryEnd = binaryCenter;
		}
		else {
			binaryStart = binaryCenter;
		}
	}
}

void DoubleVanishingPoint::Deserialize(const json& segment)
{
	this->coefficient_one = segment["coefficient_one"];
	this->coefficient_two = segment["coefficient_two"];

	this->measure_one.Deserialize(segment["measure_one"]);
	this->measure_two.Deserialize(segment["measure_two"]);
	this->vPoint_one.Deserialize(segment["vPoint_one"]);
	this->vPoint_two.Deserialize(segment["vPoint_two"]);
}
