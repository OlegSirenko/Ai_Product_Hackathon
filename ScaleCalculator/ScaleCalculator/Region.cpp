#include "Region.h"

Region::Region(const std::vector<Point> &corners)
{
	this->corners = corners;
}

std::vector<Point>* Region::getCorners()
{
	return &(this->corners);
}
