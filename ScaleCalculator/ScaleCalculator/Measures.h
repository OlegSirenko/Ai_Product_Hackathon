 #pragma once
#include "json.hpp"
using json = nlohmann::json;

struct Point;
struct Line;
struct LineSegment;

/// <summary>
/// Coordinates of a point.
/// </summary>
struct Point {
	double x{0}, y{0};
	Point() = default;
	Point(double x, double y);
	void Deserialize(const json& segment);
};

/// <summary>
/// Represents line equation in a form "y = ax + b".
/// </summary>
struct Line
{
	double a{ 0 }, b{ 0 };
	Line() = default;
	Line(Point first, Point second);
	Line(LineSegment segment);
	void Deserialize(const json &segment);
};

/// <summary>
/// Represents measured line segment in the allowed region of the Image.
/// </summary>
struct LineSegment {
	Point start, end;
	double length;

	LineSegment() = default;
	LineSegment(Point start, Point end, double length);

	double GetPixelLength();
	Point GetUnitVectorEnd();
	LineSegment BuildCroppedSegmentFromPoint(Point start,double pixelLength);
	void Deserialize(const json& segment);
};

Line BuildPerpendicular(Line line, Point point);
Point CalculateIntersection(Line first, Line second);
double CalculateDistance(Point start, Point end);
