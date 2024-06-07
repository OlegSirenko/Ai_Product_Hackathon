#include "SingleVanishingPoint_simplified.h"

SingleVanishingPoint_simplified::SingleVanishingPoint_simplified(std::vector<Point> corners, LineSegment measure, Point vPoint):Region(corners)
{
	this->measure = measure;
	this->vPoint = vPoint;
}

Point SingleVanishingPoint_simplified::buildEndpoint_approximate(Point start, LineSegment direction)
{
	return Point();
}

Point SingleVanishingPoint_simplified::buildEndpoint(Point start, LineSegment direction)
{
	throw "Not Implemented";
}
