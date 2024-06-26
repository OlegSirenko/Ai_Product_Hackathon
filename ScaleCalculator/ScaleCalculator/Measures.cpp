#include "Measures.h"
#include <cmath>



void Point::Deserialize(const json& segment)
{
    this->x = segment["x"];
    this->y = segment["y"];
}

void Line::Deserialize(const json& segment)
{
    this->a = segment["x"];
    this->b = segment["x"];
}

void LineSegment::Deserialize(const json& segment)
{
    this->start.Deserialize(segment["start"]);
    this->end.Deserialize(segment["end"]);
    this->length = segment["length"];
}



Point::Point(double x, double y) {
	this->x = x;
	this->y = y;
}

Line::Line(Point first, Point second)
{
    //������� ����� �������� � ������������� �������, ����� ������
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

Point CalculateIntersection(Line first, Line second)
{
    Point intersection;
    intersection.x = (first.b - second.b) / (second.a - first.a);
    intersection.y = first.a * intersection.x + first.b;
    return intersection;
}

double CalculateDistance(Point start, Point end)
{
    return sqrt(pow(end.x - start.x, 2) + pow(end.y - start.y, 2));
}