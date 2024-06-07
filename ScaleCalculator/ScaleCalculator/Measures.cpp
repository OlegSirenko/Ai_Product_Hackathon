#include "Measures.h"
#include <cmath>

Point::Point(int x, int y) {
	this->x = x;
	this->y = y;
}

Point Point::calculateIntersection(Line first, Line second)
{
    Point intersection;
    intersection.x = (first.b - second.b) / (second.a - first.a);
    intersection.y = first.a * intersection.x + first.b;
    return intersection;
}

Line::Line(Point first, Point second)
{
    //������� ����� �������� � ������������� �������, ����� ������
    if (first.x == second.x) {
        second.x += 0.00001;
    }
    this->a = (second.y - first.y) / (second.x - first.x);
    this->b = (second.x * first.y - first.x * second.y) / (second.x - first.x);
}

Line::Line(LineSegment segment) :Line(segment.end, segment.start) {}

//MeasuredDirection::MeasuredDirection(double x_size, double y_size, double length)
//{
//    this->x_size = x_size;
//    this->y_size = y_size;
//    this->length = length;
//}
//
//MeasuredDirection::MeasuredDirection(Point start, Point end, double length)
//{
//    this->x_size = end.x - start.x;
//    this->y_size = end.y - start.y;
//    this->length = length;
//}

LineSegment::LineSegment(Point start, Point end, double length)
{
    this->start = start;
    this->end = end;
    this->length = length;
}

double LineSegment::GetPixelLength()
{
    return sqrt(pow(end.x - start.x,2)+pow(end.y - end.y,2));
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

// nlohmann::json