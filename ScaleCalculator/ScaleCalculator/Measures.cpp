#include "Measures.h"
#include <cmath>

Point::Point(int x, int y) {
	this->x = x;
	this->y = y;
}

Point CalculateIntersection(Line first, Line second)
{
    Point intersection;
    intersection.x = (first.b - second.b) / (second.a - first.a);
    intersection.y = first.a * intersection.x + first.b;
    return intersection;
}

Line::Line(Point first, Point second)
{
    //костыль чтобы работало с вертикальными прямыми, нужно убрать
    if (first.x == second.x) {
        second.x += 0.001;
    }
    if (first.y == second.y) {
        second.y += 0.001;
    }
    this->a = (second.y - first.y) / (second.x - first.x);
    this->b = (second.x * first.y - first.x * second.y) / (second.x - first.x);
}

Line::Line(LineSegment segment) :Line(segment.end, segment.start) {}

LineSegment::LineSegment(Point start, Point end, double length)
{
    this->start = start;
    this->end = end;
    this->length = length;
}

double LineSegment::GetPixelLength()
{
    return sqrt(pow(end.x - start.x,2)+pow(end.y - start.y,2));
}

Point LineSegment::GetUnitVectorEnd()
{
    Point unitVectorEnd;
    unitVectorEnd.x = (end.x - start.x) / GetPixelLength();
    unitVectorEnd.y = (end.y - start.y) / GetPixelLength();
    return unitVectorEnd;
}

LineSegment LineSegment::BuildCroppedSegmentFromPoint(Point start, double pixelLength)
{
    Point vectorEnd = GetUnitVectorEnd();
    vectorEnd.x *= pixelLength;
    vectorEnd.y *= pixelLength;

    vectorEnd.x += start.x;
    vectorEnd.y += start.y;
    LineSegment segment(start, vectorEnd, length);
    return segment;
}

Line BuildPerpendicular(Line line, Point point)
{
    Line perpendicular;
    perpendicular.a = -1 / line.a;
    perpendicular.b = (point.x / line.a + point.y);
    return perpendicular;
}
