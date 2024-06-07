 #pragma once

struct Point;
struct Line;
struct LineSegment;
struct MeasuredDirection;

/// <summary>
/// Coordinates of a point.
/// </summary>
struct Point {
	double x{0}, y{0};
	Point() = default;
	Point(int x, int y);
	static Point calculateIntersection(Line first, Line second);
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
};


///// <summary>
///// Represents a free vector and its corresponding length in centimeters.
///// </summary>
//const struct MeasuredDirection {
//    double x_size;
//	double y_size;
//	double length;
//
//	/// <summary>
//	/// Construct a MeasuredDirection.
//	/// </summary>
//	/// <param name="x_size">X difference between vector end and start.</param>
//	/// <param name="y_size">Y difference between vector end and start.</param>
//	/// <param name="length">Length of vector in centimeters.</param>
//	MeasuredDirection(double x_size, double y_size, double length);
//
//	/// <summary>
//	/// Construct a MeasuredDirection.
//	/// </summary>
//	/// <param name="x_size">X difference between vector end and start.</param>
//	/// <param name="y_size">Y difference between vector end and start.</param>
//	/// <param name="length">Length of vector in centimeters.</param>
//	MeasuredDirection(Point start, Point end, double length);
//};

